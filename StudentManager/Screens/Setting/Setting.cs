using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Screens.Setting
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            dashboardUC1.BringToFront();
            Dashboardlbl.Text = "Dashboard";

        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void SwitchOffButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            Dashboardlbl.Text = "Dashboard";
            dashboardUC1.BringToFront();

        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            Dashboardlbl.Text = "Change Password";
            changePasswordUC1.BringToFront();
        }
    }
}
