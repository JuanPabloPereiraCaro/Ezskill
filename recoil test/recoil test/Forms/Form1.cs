using System;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using System.Threading;
using InputClass;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Timer = System.Timers.Timer;
using System.Timers;
using System.IO;

namespace PUBGSucks
{
    public partial class Form1 : Form
    {

        Timer recoilTimer;
        Timer speedTimer;
        string File_Path = @"./CFG/Config.txt";
        string Dir_Path = @"./CFG/";
        string[] recoil_values;
        int recoil = 50;
        int bulletspeed = 50;
        int currentrecoil = 0;
        int loops = 0;
        int increasespeed = 5;
        int click_counter = 0;
        bool activated;
        bool stop;
        Stopwatch stopWatch = new Stopwatch();
 
        public const int SW_SHOWNOACTIVATE = 4;
        public const int HWND_TOPMOST = -1;
        public const uint SWP_NOACTIVATE = 0x0010;

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(
          int hWnd,             // Window handle
          int hWndInsertAfter,  // Placement-order handle
          int X,                // Horizontal position
          int Y,                // Vertical position
          int cx,               // Width
          int cy,               // Height
          uint uFlags
        );         // Window positioning flags

        static void ShowInactiveTopmost(Form frm)
        {
            ShowWindow(frm.Handle, SW_SHOWNOACTIVATE);
            SetWindowPos(frm.Handle.ToInt32(), HWND_TOPMOST,
            frm.Left, frm.Top, frm.Width, frm.Height,
            SWP_NOACTIVATE);
        }

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]

        static extern IntPtr GetForegroundWindow();
        private IKeyboardMouseEvents m_Events;

        public Form1()
        {
            InitializeComponent();
            SubscribeGlobal();
        }
     
        private void SubscribeGlobal()
        {
            Unsubscribe();
            Subscribe(Hook.GlobalEvents());
        }

        private void Subscribe(IKeyboardMouseEvents events)
        {
            m_Events = events;
            m_Events.KeyDown += OnKeyDown;
            m_Events.MouseDown += OnMouseDown;
            m_Events.MouseUp += OnMouseUp;
        }

        public void recoilTimerEvent(Object source, ElapsedEventArgs e)
        {
                int increaser = (int)stopWatch.ElapsedMilliseconds;
                currentrecoil = recoil + loops / increasespeed;
                loops++;
        }

        public void speedTimerEvent(Object source, ElapsedEventArgs e)
        {
           
            Class1.MouseMoves(0, currentrecoil);
            Console.WriteLine(currentrecoil / 2);
           
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F2)
            {
                if (activated == false)
                {
                    activated = true;
                    GetForegroundWindow();
                    lblOnOff.Text = "ON";
                    lblOnOff.ForeColor = System.Drawing.Color.Green;
                  
                }
                else if (activated == true)
                {
                    activated = false;
                    click_counter = 0;
                    lblOnOff.Text = "OFF";
                    lblOnOff.ForeColor = System.Drawing.Color.Red;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                recoil--;
                txtSWRecoil.Text = System.Convert.ToString(recoil);

            }

            if (e.KeyCode == Keys.Up)
            {
                recoil++;
                txtSWRecoil.Text = System.Convert.ToString(recoil);

            }

           /* if (e.KeyCode == Keys.Right)
            {
                bulletspeed++;
                txtSWSpeed.Text = Convert.ToString(bulletspeed);
                speedTimer.Interval = bulletspeed;
            }

            if (e.KeyCode == Keys.Left)
            {
                bulletspeed--;
                txtSWSpeed.Text = Convert.ToString(bulletspeed);
                speedTimer.Interval = bulletspeed;
            }*/

            if (e.KeyCode == Keys.D2)
            {
                activated = true;
                recoil = 20;                
                txtSecondWepRecoil.Text = System.Convert.ToString(recoil);


                lbl1stWeapon.ForeColor = System.Drawing.Color.Magenta;
                lbl2ndWeapon.ForeColor = System.Drawing.Color.Yellow;

            }
            else if(e.KeyCode == Keys.D1)
            {

                activated = true;
                string selected_weapon = cbWeaponSelector.Text;
                string[] values = File.ReadAllLines(File_Path);

                switch (selected_weapon)
                {
                    case "SNIPER":
                        recoil = Convert.ToInt32(values[1]);
                        bulletspeed = Convert.ToInt32(values[2]);

                        txtSWRecoil.Text = Convert.ToString(recoil);
                        txtSWSpeed.Text = Convert.ToString(bulletspeed);

                        break;
                    case "M416":
                        recoil = Convert.ToInt32(values[3]);
                        bulletspeed = Convert.ToInt32(values[4]);


                        txtSWRecoil.Text = Convert.ToString(recoil);
                        txtSWSpeed.Text = Convert.ToString(bulletspeed);
                        break;
                    case "QBZ":
                        recoil = Convert.ToInt32(values[5]);
                        bulletspeed = Convert.ToInt32(values[6]);


                        txtSWRecoil.Text = Convert.ToString(recoil);
                        txtSWSpeed.Text = Convert.ToString(bulletspeed);
                        break;
                    case "SCAR-L":
                        recoil = Convert.ToInt32(values[7]);
                        bulletspeed = Convert.ToInt32(values[8]);


                        txtSWRecoil.Text = Convert.ToString(recoil);
                        txtSWSpeed.Text = Convert.ToString(bulletspeed);
                        break;
                    case "M249":
                        recoil = Convert.ToInt32(values[9]);
                        bulletspeed = Convert.ToInt32(values[10]);


                        txtSWRecoil.Text = Convert.ToString(recoil);
                        txtSWSpeed.Text = Convert.ToString(bulletspeed);
                        break;
                    case "AKM":
                        recoil = Convert.ToInt32(values[11]);
                        bulletspeed = Convert.ToInt32(values[12]);


                        txtSWRecoil.Text = Convert.ToString(recoil);
                        txtSWSpeed.Text = Convert.ToString(bulletspeed);
                        break;
                }

                lbl1stWeapon.ForeColor = System.Drawing.Color.Yellow;
                lbl2ndWeapon.ForeColor = System.Drawing.Color.Magenta;
            }

            if (e.KeyCode == Keys.Tab)
            {
                click_counter++;

                activated = false;
                
                if(click_counter == 2)
                {
                    click_counter = 0;
                    activated = true;
                }

            }

            if(e.KeyCode == Keys.G || e.KeyCode == Keys.D5)
            {

                click_counter++;

                activated = false;

                if (click_counter == 2)
                {
                    click_counter = 0;
                    activated = true;
                }

            }

        }
            
        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (activated != true)
            {
                return;
            }
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.XButton1 || e.Button == MouseButtons.XButton2 || e.Button == MouseButtons.Middle)
            {
                return;
            }
            loops = 0;
            currentrecoil = recoil;
            stopWatch.Reset();
            stopWatch.Start();
            recoilTimer.Enabled = true;
           speedTimer.Enabled = true;       

        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            
            if (activated != true)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                return;
            }
            loops = 0;
            recoilTimer.Enabled = false;
            speedTimer.Enabled = false;
            stop = true;
            stopWatch.Stop();

           
        }
        
        private void cbWeaponSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selected_weapon = cbWeaponSelector.Text;
            recoil_values = System.IO.File.ReadAllLines(File_Path);

            switch (selected_weapon)
            {
                case "SNIPER":
                    recoil = Convert.ToInt32(recoil_values[1]);
                    bulletspeed = Convert.ToInt32(recoil_values[2]);

                    txtSWRecoil.Text = Convert.ToString(recoil);
                    txtSWSpeed.Text = Convert.ToString(bulletspeed);

                    break;
                case "M416":
                    recoil = Convert.ToInt32(recoil_values[3]);
                    bulletspeed = Convert.ToInt32(recoil_values[4]);

                    txtSWRecoil.Text = Convert.ToString(recoil);
                    txtSWSpeed.Text = Convert.ToString(bulletspeed);

                    break;
                case "QBZ":
                    recoil = Convert.ToInt32(recoil_values[5]);
                    bulletspeed = Convert.ToInt32(recoil_values[6]);

                    txtSWRecoil.Text = Convert.ToString(recoil);
                    txtSWSpeed.Text = Convert.ToString(bulletspeed);

                    break;
                case "SCAR-L":
                    recoil = Convert.ToInt32(recoil_values[7]);
                    bulletspeed = Convert.ToInt32(recoil_values[8]);

                    txtSWRecoil.Text = Convert.ToString(recoil);
                    txtSWSpeed.Text = Convert.ToString(bulletspeed);

                    break;
                case "M249":
                    recoil = Convert.ToInt32(recoil_values[9]);
                    bulletspeed = Convert.ToInt32(recoil_values[10]);

                    txtSWRecoil.Text = Convert.ToString(recoil);
                    txtSWSpeed.Text = Convert.ToString(bulletspeed);

                    break;
                case "AKM":
                    recoil = Convert.ToInt32(recoil_values[11]);
                    bulletspeed = Convert.ToInt32(recoil_values[12]);

                    txtSWRecoil.Text = Convert.ToString(recoil);
                    txtSWSpeed.Text = Convert.ToString(bulletspeed);

                    break;
            }

        }

        private void Unsubscribe()
        {
            if (m_Events == null) return;

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cbWeaponSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {

                e.SuppressKeyPress = true;

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblComputerName.Text = Environment.MachineName;
            lblDate.Text = DateTime.Now.ToString("d/M/yyyy");

            if (Directory.Exists(Dir_Path) && File.Exists(File_Path))
            {

                btnCreateDir.Enabled = false;
                btnCreateDir.Visible = false;

            }
            else
            {

                MessageBox.Show("There is no directory for your CFG file created, before you do ANYTHING click on the 'CREATE DIR' button, otherwise" +
                    " you wont be able to save your weapon configuration...", "STOP RIGHT THERE!", MessageBoxButtons.OK);


            }

            recoilTimer = new Timer();
            recoilTimer.Interval = 90;// interval in milliseconds
            recoilTimer.Enabled = false;
            recoilTimer.Elapsed += recoilTimerEvent;
            recoilTimer.AutoReset = true;

           speedTimer = new Timer();
            speedTimer.Interval = 90;// interval in milliseconds
            speedTimer.Enabled = false;
            speedTimer.Elapsed += speedTimerEvent;
            speedTimer.AutoReset = true;

        }

        private void btnCreateDir_Click(object sender, EventArgs e)
        {

            DirectoryInfo di = Directory.CreateDirectory("./CFG");
            File.AppendAllLines(File_Path, new[] {"EXISTS", "50", "50", "50", "50", "50", "50", "50", "50", "50", "50", "50", "50"});

            btnCreateDir.Enabled = false;
            btnCreateDir.Visible = false;

            MessageBox.Show("Dirs and CFG file created properly, please DO NOT touch them.", "Succeed", MessageBoxButtons.OK);

        }

        private void btnSaveConf_Click(object sender, EventArgs e)
        {

            string selected_weapon = cbWeaponSelector.Text;
            recoil_values = System.IO.File.ReadAllLines(File_Path);

            switch (selected_weapon)
            {
                case "SNIPER":

                    recoil_values[1] = txtSWRecoil.Text;
                    recoil_values[2] = txtSWSpeed.Text;

                    break;
                case "M416":

                    recoil_values[3] = txtSWRecoil.Text;
                    recoil_values[4] = txtSWSpeed.Text;

                    break;
                case "QBZ":

                    recoil_values[5] = txtSWRecoil.Text;
                    recoil_values[6] = txtSWSpeed.Text;

                    break;
                case "SCAR-L":

                    recoil_values[7] = txtSWRecoil.Text;
                    recoil_values[8] = txtSWSpeed.Text;

                    break;
                case "M249":

                    recoil_values[9] = txtSWRecoil.Text;
                    recoil_values[10] = txtSWSpeed.Text;

                    break;
                case "AKM":

                    recoil_values[11] = txtSWRecoil.Text;
                    recoil_values[12] = txtSWSpeed.Text;

                    break;
            }

            File.WriteAllLines(File_Path, recoil_values);

            MessageBox.Show("Recoil configuration for weapon " + selected_weapon + " saved succesfully!", "Saved Succesfully!", MessageBoxButtons.OK);

        }

    }
}
