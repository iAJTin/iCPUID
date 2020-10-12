﻿
namespace iTin.Core.Helpers
{
    using System;
    using System.Reflection;

    using Logging;

    /// <summary>
    /// Static class which contains methods for retrieve <see cref="T:System.Assembly" /> information.
    /// </summary>
    public static class AssemblyHelper
    {
        /// <summary>
        /// Returns <see cref="T:System.Uri" /> that contains full path to current assembly.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Uri" /> that contains full path to current assembly.
        /// </returns>
        public static Uri GetFullAssemblyUri()
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: AssemblyHelper");
            Logger.Instance.Debug($" Returns an {typeof(Uri)} that contains full path to current assembly");
            Logger.Instance.Debug($" > Signature: ({typeof(Uri)}) GetFullAssemblyUri()");

            Uri result = new Uri(Assembly.GetCallingAssembly().CodeBase);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
    }
}
