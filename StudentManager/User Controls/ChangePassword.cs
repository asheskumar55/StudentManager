using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using AshesFramework;
using StudentManager.Utilities;
using StudentManager.Icons;
using System.Security.Cryptography;
using StudentManager.Modal;

namespace StudentManager.User_Controls
{
    public partial class ChangePasswordUC : UserControl
    {
        public ChangePasswordUC()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(IsValidated())
            {
                try{
                    UpdatePassword();
                    }
                catch(ApplicationException ex)
                {
                    MessageBox.Show("Error: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdatePassword()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.GetScalarValue("usp_changepassword", changepassword());
            MessageBox.Show("Updated successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Change password
        private DbParameter[] changepassword()
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter dbparam1 = new DbParameter();
            DbParameter dbparam2 = new DbParameter();
            dbparam2.Parameter = "@Password";
            dbparam2.Value = Encryption.Encrypt(NewPasswordTextBox.Text.Trim());
            parameters.Add(dbparam2);

            dbparam1.Parameter = "@UserName";
            dbparam1.Value =(LoggedInUser.UserName);
            parameters.Add(dbparam1);

            return parameters.ToArray();

        }

        private bool IsValidated()
        {
            if (NewPasswordTextBox.Text.Trim()==String.Empty)
            {
                MessageBox.Show("New Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewPasswordTextBox.Focus();
                return false;
            }
            if (ReenterNewPasswordTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Reenter New Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReenterNewPasswordTextBox.Focus();
                return false;
            }
            if (NewPasswordTextBox.Text.Trim() != ReenterNewPasswordTextBox.Text.Trim())
            {
                MessageBox.Show("New Password doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
