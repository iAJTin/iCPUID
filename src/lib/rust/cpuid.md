
# What is cpuid ?
**cpuid** is a native library created in **[Rust]** language, which makes the calls to the **CPUID** instruction.


# How to install Rust ?

For install **Rust**, please see https://www.rust-lang.org/tools/install

It's very simple, just follow the instructions provided in the previous link for your favorite operating system.

# Code

The code is in the **[lib.rs]** file. 

This file contains

- **Structures**

|Name|Description|
|:------|:----------|
|CpuidResult| Public structure that contains the definition of the cpu registers |

- **Methods**

|Signature|Description|
|:------|:----------|
|cpuid(leaf: u32) -> CpuidResult| Returns the result of the `cpuid` instruction for a given `leaf` |
|cpuid_with_subleaf(leaf: u32, subleaf: u32) -> CpuidResult| Returns the result of the `cpuid` instruction for a given `leaf` and `sub leaf` |
|cpuid_is_supported() -> bool| Returns a `bool` value that indicates whether the `cpuid` instruction is available for this system |

- **Test**

In the test module `mod tests (line 219)`, you can see various test methods, to see the usage.



[Rust]: https://www.rust-lang.org/
[lib.rs]: https://github.com/iAJTin/iCPUID/blob/main/src/lib/rust/cpuid/src/lib.rs
[documentation]: https://github.com/iAJTin/iCPUID/blob/main/src/lib/rust/cpuid/doc/settings.html
