using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace GlobalWordCount
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        [DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(ProcessDPIAwareness value);

        private enum ProcessDPIAwareness
        {
            ProcessDPIUnaware = 0,
            ProcessSystemDPIAware = 1,
            ProcessPerMonitorDPIAware = 2
        }

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        public Form1()
        {
            SetDpiAwareness();
            InitializeComponent();

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info; //Shows the info icon so the user doesn't think there is an error.
            notifyIcon1.Icon = new Icon(this.Icon, 40, 40);
            notifyIcon1.Text = "Global Word Count Settings";

            ckShift.Checked = true;
            txtChar.Text = "W";

            RegHotkey();
        }

        private void RegHotkey()
        {
            int Mod = 0;
            if (ckAlt.Checked)
                Mod += 1;
            if (ckControl.Checked)
                Mod += 2;
            if (ckShift.Checked)
                Mod += 4;
            if (ckWindows.Checked)
                Mod += 8;

            KeysConverter kc = new KeysConverter();

            RegisterHotKey(this.Handle, 0, Mod, kc.ConvertFromString(txtChar.Text).GetHashCode());
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. 

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.*/

                while (KeysDown())
                    Thread.Sleep(50);

                string prev = Clipboard.GetText(TextDataFormat.Text);

                SendKeys.Send("^(c)");

                string data = Clipboard.GetText(TextDataFormat.Text);

                notifyIcon1.BalloonTipText = data.Replace(" ", string.Empty).Length + " chars" + "\n" + data.Split(' ').Length + " words";
                notifyIcon1.BalloonTipTitle = "Word Count";

                notifyIcon1.ShowBalloonTip(3000);

                try
                {
                    if (prev != null || prev != "")
                        Clipboard.SetText(prev, TextDataFormat.Text);
                }
                catch
                { }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
        }

        private void TxtChar_TextChanged(object sender, EventArgs e)
        {
            txtChar.Text = txtChar.Text.ToUpper();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
            RegHotkey();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.BalloonTipText = "Global Word Count has been minimized";
                notifyIcon1.BalloonTipTitle = "Information";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                RegHotkey();
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            RegHotkey();
        }

        public static bool KeysDown()
        {
            foreach (Key key in Enum.GetValues(typeof(Key)))
            {
                try
                {
                    if (Keyboard.IsKeyDown(key))
                        return true;
                }
                catch
                {
                    continue;
                }
            }
            return false;   
        }
        private static void SetDpiAwareness()
        {
            try
            {
                if (Environment.OSVersion.Version.Major >= 6)
                    SetProcessDpiAwareness(ProcessDPIAwareness.ProcessPerMonitorDPIAware);
            }
            catch (EntryPointNotFoundException)
            {
            }
        }
    }
}
