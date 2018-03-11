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
    public partial class BranchInfoForm : TemplateForm
    {
        public BranchInfoForm()
        {
            InitializeComponent();
        }
        public int BranchId { get; set; }

        private void BranchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TopPanelLabel.Text = BranchNameTextBox.Text;
        }

        private void LabelTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveRecordButton_Click(object sender, EventArgs e)
        {

        }


        private void ViewRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BranchInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
