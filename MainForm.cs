using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POEHelper
{
    public partial class MainForm : Form
    {
        public IntPtr hWnd;

        private enum KeyHelp
        {
            ITEMLEVEL = 100,
            OOS = 200,
            REMAINING = 400,
        }

        public MainForm()
        {
            InitializeComponent();
        }

        #region ui event

        private void checkBoxGlobalHotKey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGlobalHotKey.Checked)
            {
                InitRegisterKey();
            }
            else
            {
                UnRegisterKey();
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("還沒寫好，是要設定什麼。\nF2 = OOS、F3 = RAMAINING、F4 = ITEMLEVEL");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnRegisterKey();
        }

        #endregion

        #region event function

        private void InitRegisterKey()
        {
            Win32API.RegisterHotKey(Handle, (int)KeyHelp.OOS, (int)Win32API.KeyModifiers.None, (UInt32)Keys.F2);
            Win32API.RegisterHotKey(Handle, (int)KeyHelp.REMAINING, (int)Win32API.KeyModifiers.None, (UInt32)Keys.F3);
            Win32API.RegisterHotKey(Handle, (int)KeyHelp.ITEMLEVEL, (int)Win32API.KeyModifiers.None, (UInt32)Keys.F4);
        }

        public void UnRegisterKey()
        {
            Win32API.UnregisterHotKey(Handle, (int)KeyHelp.OOS);
            Win32API.UnregisterHotKey(Handle, (int)KeyHelp.REMAINING);
            Win32API.UnregisterHotKey(Handle, (int)KeyHelp.ITEMLEVEL);
        }

        //按下設定的鍵時調用該函數
        private void ProcessHotkey(Message m)
        {
            Console.WriteLine("ProcessHotkey");
            //IntPtr用於表示指針或句柄的平台特定類型
            IntPtr id = m.WParam;
            string sid = id.ToString();

            if (sid == ((int) KeyHelp.OOS).ToString())
            {
                SendKeyboardMessage("/oos");
            }
            else if (sid == ((int)KeyHelp.ITEMLEVEL).ToString())
            {
                SendKeyboardMessage("/itemlevel");
            }
            else if (sid == ((int)KeyHelp.REMAINING).ToString())
            {
                SendKeyboardMessage("/remaining");
            }
        }

        //重寫WndProc()方法，通過監視系統消息，來調用過程
        protected override void WndProc(ref Message m)//監視Windows消息
        {
            const int WM_HOTKEY = 0x0312;
            //如果m.Msg的值為0x0312那麼表示用戶按下了熱鍵
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    ProcessHotkey(m);//按下熱鍵時調用ProcessHotkey()函數
                    break;
            }

            base.WndProc(ref m); //將系統消息傳遞自父類的WndProc
        }

        #endregion

        #region keyboard event

        private void SendKeyboardMessage(string msg)
        {

            SendKeys.Send("{ENTER}");
            SendKeys.Flush();
            foreach (char c in msg)
            {
                SendKeys.Send(c.ToString());
            }
            SendKeys.Flush();
            SendKeys.Send("{ENTER}");
            SendKeys.Flush();
        }

        #endregion

        
    }
}
