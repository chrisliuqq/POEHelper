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

        public enum KeyCode
        {
            VK_BACK = 0x08,
            VK_TAB = 0x09,
            VK_ENTER = 0x0D,
            VK_CONTROL = 0x11,
            VK_MENU = 0x12,
            VK_SPACE = 0x20,
            VK_UP = 0x26,
            VK_RIGHT = 0x27,
            VK_DOWN = 0x28,
            V = 0x56,
            WM_GETTEXT = 0x000D,
            WM_GETTEXTLENGTH = 0x000E,
            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101,
            WM_CHAR = 0x0102,
            WM_SYSKEYDOWN = 0x0104,
            WM_SYSCHAR = 0x0106,
            WM_SYSCOMMAND = 0x0112,
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_PASTE = 0x0302,

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

        [DllImport("imm32.dll")]
        public static extern bool ImmGetOpenStatus(IntPtr hIMC);
    }
}
