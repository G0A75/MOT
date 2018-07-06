#region Namespace

using System;
using System.Runtime.InteropServices;

using MOT.Native;

#endregion

namespace MOT.Utilities
{
    internal class PropertiesDialog
    {
        #region Methods

        /// <summary>Show the file properties dialog.</summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool Show(string filePath)
        {
            SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
            info.cbSize = Marshal.SizeOf(info);
            info.lpVerb = "properties";
            info.lpFile = filePath;
            info.nShow = PropertiesConstants.SW_SHOW;
            info.fMask = PropertiesConstants.SEE_MASK_INVOKEIDLIST;
            return Shell32.ShellExecuteEx(ref info);
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;

            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;

            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;

            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;

            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;

            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;

            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;

            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        private struct PropertiesConstants
        {
            public const uint SEE_MASK_INVOKEIDLIST = 12;
            public const int SW_SHOW = 5;
        }

        #endregion
    }
}