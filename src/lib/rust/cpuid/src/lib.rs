#![feature(asm)]
#![crate_name = "cpuid"]

#[repr(C)]
#[derive(Debug)]
///
/// Defines a structure that contains the value of the cpu registers
///
pub struct CpuidResult {
    ///
    /// `eax` register.
    ///
    pub eax: u32,

    ///
    /// `ebx` register.
    ///
    pub ebx: u32,

    ///
    /// `ecx` register.
    ///
    pub ecx: u32,

    ///
    /// `edx` register.
    ///
    pub edx: u32,
}



#[no_mangle]
/// Returns the result of the `cpuid` instruction for a given `leaf`.
///
/// The `leaf` refers to the `eax` register.
///
/// # Arguments
///
/// * `leaf` - Defines the value of the `eax` register.
///
/// # Returns
///
/// Returns a structure of type `CpuidResult` that contains the result of the operation.
///
/// # Examples
/// 
/// ```rust
/// ...
/// ...
/// // CPUID’s Highest Value for Basic Processor Information and the Vendor
/// // Identification String.
/// //
/// // When CPUID executes with EAX set to 0, the processor returns the highest
/// // value the CPUID recognizes for returning basic processor information.
/// let result: CpuidResult = cpuid(0x00);
///
/// println!("eax=00h");
/// println!(
///     "{}",
///     format!(
///         "eax: {:X}, ebx: {:X}, ecx: {:X}, edx: {:X}",
///         result.eax,
///         result.ebx,
///         result.ecx,
///         result.edx));
/// ...
/// ...
/// ```
pub extern fn cpuid(leaf: u32) -> CpuidResult {
    cpuid_with_subleaf(leaf, 0)
}

#[no_mangle]
/// Returns the result of the `cpuid` instruction for a given `leaf` and `sub leaf`.
///
/// The `leaf` refers to the `eax` register.
///
/// # Arguments
///
/// * `leaf` - A `u32` value that defines the value of the `eax` register.
///
/// * `subleaf` - A `u32` value that defines the value of the `ecx` register.
///
/// # Returns
///
/// Returns a structure of type `CpuidResult` that contains the result of the operation.
///
/// # Examples
///
/// ```rust
/// ...
/// ...
///
/// // Returns Structured Extended Feature Enumeration Information.
/// //
/// // When CPUID executes with EAX set to 07H and ECX = 0, the processor returns
/// // information about the maximum input value for sub-leaves that contain
/// // extended feature flags.
/// let result: CpuidResult = cpuid_with_subleaf(0x07, 0x00);;
///
/// println!("eax=00h, ecx=00h");
/// println!(
///     "{}",
///     format!(
///         "eax: {:X}, ebx: {:X}, ecx: {:X}, edx: {:X}",
///         result.eax,
///         result.ebx,
///         result.ecx,
///         result.edx));
/// ...
/// ...
/// ```
pub extern fn cpuid_with_subleaf(leaf: u32, subleaf: u32) -> CpuidResult {
    
    let eax: u32;
    let ebx: u32;
    let ecx: u32;
    let edx: u32;

    unsafe{

        asm!("cpuid",
            inout("eax") leaf => eax,
            inout("ecx") subleaf => ecx,
            lateout("ebx") ebx,
            lateout("edx") edx,);
    }

    CpuidResult { eax, ebx, ecx, edx }
}
  
#[no_mangle]
/// Returns a `bool` value that indicates whether the `cpuid` instruction
/// is available for this system.
///
/// # Examples
///
/// ```rust
/// ...
/// ...
/// let cpuid_is_available: bool = has_cpuid();
///
/// println!("Has cpuid, {}", cpuid_is_available);
/// ...
/// ...
/// ```
pub extern fn cpuid_is_supported() -> bool {
    #[cfg(target_env = "sgx")]
    {
        false
    }
    #[cfg(all(not(target_env = "sgx"), target_arch = "x86_64"))]
    {
        true
    }
    #[cfg(all(not(target_env = "sgx"), target_arch = "x86"))]
    {
        // Optimization for i586 and i686 Rust targets which SSE enabled and support cpuid:
        #[cfg(target_feature = "sse")]
        {
            true
        }

        // If SSE is not enabled, detect whether cpuid is available:
        #[cfg(not(target_feature = "sse"))]
        unsafe {
            // On `x86` the `cpuid` instruction is not always available.
            // This follows the approach indicated in:
            // http://wiki.osdev.org/CPUID#Checking_CPUID_availability
            // https://software.intel.com/en-us/articles/using-cpuid-to-detect-the-presence-of-sse-41-and-sse-42-instruction-sets/
            // which detects whether `cpuid` is available by checking whether
            // the 21st bit of the EFLAGS register is modifiable or not.
            // If it is, then `cpuid` is available.
            let result: u32;
            let _temp: u32;
            llvm_asm!(r#"
                    # Read eflags into $0 and copy it into $1:
                    pushfd
                    pop     $0
                    mov     $1, $0
                    # Flip 21st bit of $0.
                    xor     $0, 0x200000
                    # Set eflags to the value of $0
                    #
                    # Bit 21st can only be modified if cpuid is available
                    push    $0
                    popfd          # A
                    # Read eflags into $0:
                    pushfd         # B
                    pop     $0
                    # xor with the original eflags sets the bits that
                    # have been modified:
                    xor     $0, $1
                    "#
                    : "=r"(result), "=r"(_temp)
                    :
                    : "cc", "memory"
                    : "intel");
            // There is a race between popfd (A) and pushfd (B)
            // where other bits beyond 21st may have been modified due to
            // interrupts, a debugger stepping through the asm, etc.
            //
            // Therefore, explicitly check whether the 21st bit
            // was modified or not.
            //
            // If the result is zero, the cpuid bit was not modified.
            // If the result is `0x200000` (non-zero), then the cpuid
            // was correctly modified and the CPU supports the cpuid
            // instruction:
            (result & 0x200000) != 0
        }
    }
}



#[cfg(test)]
mod tests {
    use crate::{CpuidResult, cpuid_with_subleaf, cpuid_is_supported, cpuid};

    #[test]
    fn has_cpuid_test() {

        let cpuid_is_available: bool = cpuid_is_supported();
        println!("Has cpuid, {}", cpuid_is_available);

    }
 
    #[test]
    fn cpuid_leaf_00h() {

        let result: CpuidResult = cpuid(0x00);

        println!("eax=00h");
        println!(
            "{}",
            format!(
                "eax: {:X}, ebx: {:X}, ecx: {:X}, edx: {:X}",
                result.eax,
                result.ebx,
                result.ecx,
                result.edx));

    }

    #[test]
    fn cpuid_leaf_01h() {

        let result: CpuidResult = cpuid(0x01);

        println!("eax=01h");
        println!(
            "{}",
            format!(
                "eax: {:X}, ebx: {:X}, ecx: {:X}, edx: {:X}",
                result.eax,
                result.ebx,
                result.ecx,
                result.edx));

    }
    
    #[test]
    fn cpuid_leaf_07h_subleaf_00h() {

        let result: CpuidResult = cpuid_with_subleaf(0x07, 0x00);

        println!("eax=07h, ecx=00h");
        println!(
            "{}",
            format!(
                "eax: {:X}, ebx: {:X}, ecx: {:X}, edx: {:X}",
                result.eax,
                result.ebx,
                result.ecx,
                result.edx));

    }
}
