using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace POEHelper
{
    partial class Win32API
    {
        //組合鍵枚舉
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }

        // 註冊全域熱鍵
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(
            IntPtr handleWindow,					// handle to window
            int identifier,							// hot key identifier
            uint fsModifiers,						// key-modifier options
            UInt32 virtualKey						// virtual-key code
        );

        // 解除全域熱鍵
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(
            IntPtr handleWindow,					// handle to window
            int identifier							// hot key identifier
        );

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll", EntryPoint = "PostMessage", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern void PostMessage(IntPtr hWnd, int msg, int wParam, int lParam);
    }
}
