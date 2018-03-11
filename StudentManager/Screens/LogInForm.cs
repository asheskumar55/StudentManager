﻿using AshesFramework;
using StudentManager.Screens.Templates;
using StudentManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace StudentManager.Screens
{
    public partial class LogInForm : TemplateForm
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        public string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());

                bool IsLoginDetailsCorrect = Convert.ToBoolean(db.GetScalarValue("usp_UsersCheckLoginDetails", GetParameters())); 
                if (IsLoginDetailsCorrect)
                {
                    this.Hide();
                    DashBoardForm df = new DashBoardForm();
                    df.Show();
                }
                else
                {
                    MessageBox.Show("Username/Password is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DbParameter[] GetParameters()
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter dbparam1 = new DbParameter();
            dbparam1.Parameter = "@UserName";
            dbparam1.Value = Encrypt(UserNameTextBox.Text);
            parameters.Add(dbparam1);

            DbParameter dbparam2 = new DbParameter();
            dbparam2.Parameter = "@Password";
            dbparam2.Value = Encrypt(PasswordTextBox.Text);
            parameters.Add(dbparam2);

            return parameters.ToArray();
        }

        private bool IsFormValid()
        {
            if(UserNameTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Username is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                UserNameTextBox.Focus();
                return false;

            }
            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
                return false;

            }
            return true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
