using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSync
{
    public partial class UserConfig : Form
    {
        public UserConfig()
        {
            InitializeComponent();
        }

        private void UserConfig_Load(object sender, EventArgs e)
        {

            sendPortTB.Text = Properties.Settings.Default.SendPort;
            receivePortTB.Text = Properties.Settings.Default.RecvPort;
            nameTB.Text = Properties.Settings.Default.Name;
            colorBtn.BackColor = Color.FromArgb(
                Int32.Parse(Properties.Settings.Default.Color.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                Int32.Parse(Properties.Settings.Default.Color.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                Int32.Parse(Properties.Settings.Default.Color.Substring(4, 2), System.Globalization.NumberStyles.HexNumber)
            );
            secretTb.Text = Properties.Settings.Default.Secret;


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SendPort = sendPortTB.Text ;
            Properties.Settings.Default.RecvPort = receivePortTB.Text;
            Properties.Settings.Default.Name = nameTB.Text;
            Properties.Settings.Default.Color =
              colorBtn.BackColor.R.ToString("X2") +
              colorBtn.BackColor.G.ToString("X2") +
              colorBtn.BackColor.B.ToString("X2");
            Properties.Settings.Default.Secret = secretTb.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void setColor_Click(object sender, EventArgs e)
        {
            colorPick.ShowDialog();
            ((Button)sender).BackColor = colorPick.Color;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void secretGenBtn_Click(object sender, EventArgs e)
        {
            secretTb.Text = MulticonMgr.generateKey();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.SendPort = sendPortTB.Text;
            Properties.Settings.Default.RecvPort = receivePortTB.Text;
            Properties.Settings.Default.Name = nameTB.Text;
            Properties.Settings.Default.Color =
              colorBtn.BackColor.R.ToString("X2") +
              colorBtn.BackColor.G.ToString("X2") +
              colorBtn.BackColor.B.ToString("X2");
            Properties.Settings.Default.Secret = secretTb.Text;
            this.Close();
        }

    }
}
