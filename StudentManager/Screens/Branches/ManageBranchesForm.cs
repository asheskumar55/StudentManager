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

namespace StudentManager.Screens.Branches
{
    public partial class ManageBranchesForm : TemplateForm
    {
        public ManageBranchesForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewBranchButton_Click(object sender, EventArgs e)
        {
            ShowBranchInfoScreen(0, false);
        }

        private void ShowBranchInfoScreen(int branchId, bool isUpdate)
        {
            BranchInfoForm bif = new BranchInfoForm();
            bif.BranchId = branchId;
            bif.IsUpdate = isUpdate;
            bif.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
