using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GetPublicIP;
using System.Threading;

namespace Public_IP_Detector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _IPLabel.Text = "000.000.000.000";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = Public_IP_Detector.Properties.Resources.network_ico;
            this.BackColor = Color.FromArgb(000, 000, 000);
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "IP Detector | Freeware";
            this.button1.FlatStyle = FlatStyle.Flat;
            this._IPupdateBtn.FlatStyle = FlatStyle.Flat;
            this._IPupdateBtn.BackColor = Color.FromArgb(100, 100, 250);
            this.button1.BackColor = Color.FromArgb(150, 150, 150);
            Thread.Sleep(500);
            _IPLabel.Text = IPV4.GetPublicAddress();
            this.pictureBox1.BackgroundImage = Public_IP_Detector.Properties.Resources.network_icon;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            if (_IPLabel.Text != null)
            {
                this.panel1.BackColor = Color.SeaGreen;
            }

            //Form form1 = new Form();
            this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 015) + this.Width, 0);
            Rectangle res = Screen.PrimaryScreen.Bounds;

            // Calculate location (etc. 1366 Width - form size...)
            this.Location = new Point(res.Width - Size.Width); 
            
        }

        private void _IPupdateBtn_Click(object sender, EventArgs e)
        {
            _IPLabel.Text = IPV4.GetPublicAddress();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }
    }
}
