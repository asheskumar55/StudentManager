using StudentManager.Screens.Branches;
using StudentManager.Screens.Setting;
using StudentManager.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.Screens
{
    public partial class DashBoardForm : TemplateForm
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageBranchesToolStripButton_Click(object sender, EventArgs e)
        {
            ManageBranchesForm mbf = new ManageBranchesForm();
            mbf.ShowDialog();
        }
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if(imageNumber==10)
            {
                imageNumber = 1;
            }
            SlidePicture.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            LoadNextImage();

        }

        private void SlidePicture_Click(object sender, EventArgs e)
        {

        }

        private void ExitCircularButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Exit?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to Exit?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            Application.Exit();
        }

       
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingForm stf = new SettingForm();
            stf.Show();
        }

        private void LogOutCircularButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Hide();
                LogInForm lif = new LogInForm();
                lif.Show();
            }
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
          
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }
    }
}
