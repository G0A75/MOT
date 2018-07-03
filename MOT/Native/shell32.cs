#region Namespace

using System.Runtime.InteropServices;
using System.Security;

using MOT.Utilities;

#endregion

namespace MOT.Native
{
    [SuppressUnmanagedCodeSecurity]
    internal class Shell32
    {
        #region Methods

        /// <summary>Performs an operation on a specified file.</summary>
        /// <param name="lpExecInfo">
        ///     A pointer to a <see cref="PropertiesDialog.SHELLEXECUTEINFO" /> structure that contains and
        ///     receives information about the application being executed.
        /// </param>
        /// <returns>Returns TRUE if successful; otherwise, FALSE.</returns>
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern bool ShellExecuteEx(ref PropertiesDialog.SHELLEXECUTEINFO lpExecInfo);

        #endregion
    }
}