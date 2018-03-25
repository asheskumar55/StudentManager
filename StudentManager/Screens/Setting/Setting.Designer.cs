namespace StudentManager.Screens.Setting
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.DashBoardButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dashboardlbl = new System.Windows.Forms.Label();
            this.SwitchOffButton = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.changePasswordUC1 = new StudentManager.User_Controls.ChangePasswordUC();
            this.dashboardUC1 = new StudentManager.User_Controls.DashboardUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DeleteUserButton);
            this.panel1.Controls.Add(this.AddUserButton);
            this.panel1.Controls.Add(this.ChangePasswordButton);
            this.panel1.Controls.Add(this.DashBoardButton);
            this.panel1.Location = new System.Drawing.Point(-7, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 437);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.FlatAppearance.BorderSize = 0;
            this.DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserButton.ForeColor = System.Drawing.Color.White;
            this.DeleteUserButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteUserButton.Image")));
            this.DeleteUserButton.Location = new System.Drawing.Point(4, 242);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(144, 43);
            this.DeleteUserButton.TabIndex = 0;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.FlatAppearance.BorderSize = 0;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserButton.ForeColor = System.Drawing.Color.White;
            this.AddUserButton.Image = ((System.Drawing.Image)(resources.GetObject("AddUserButton.Image")));
            this.AddUserButton.Location = new System.Drawing.Point(4, 193);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(144, 43);
            this.AddUserButton.TabIndex = 0;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.White;
            this.ChangePasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangePasswordButton.Image")));
            this.ChangePasswordButton.Location = new System.Drawing.Point(4, 144);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(144, 43);
            this.ChangePasswordButton.TabIndex = 0;
            this.ChangePasswordButton.Text = "   Change Password";
            this.ChangePasswordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // DashBoardButton
            // 
            this.DashBoardButton.FlatAppearance.BorderSize = 0;
            this.DashBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoardButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardButton.ForeColor = System.Drawing.Color.White;
            this.DashBoardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashBoardButton.Image")));
            this.DashBoardButton.Location = new System.Drawing.Point(4, 95);
            this.DashBoardButton.Name = "DashBoardButton";
            this.DashBoardButton.Size = new System.Drawing.Size(144, 43);
            this.DashBoardButton.TabIndex = 0;
            this.DashBoardButton.Text = "   Dashboard";
            this.DashBoardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashBoardButton.UseVisualStyleBackColor = true;
            this.DashBoardButton.Click += new System.EventHandler(this.DashBoardButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.panel2.Location = new System.Drawing.Point(140, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 23);
            this.panel2.TabIndex = 0;
            // 
            // Dashboardlbl
            // 
            this.Dashboardlbl.AutoSize = true;
            this.Dashboardlbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardlbl.Location = new System.Drawing.Point(154, 20);
            this.Dashboardlbl.Name = "Dashboardlbl";
            this.Dashboardlbl.Size = new System.Drawing.Size(117, 23);
            this.Dashboardlbl.TabIndex = 1;
            this.Dashboardlbl.Text = "Dashboard";
            // 
            // SwitchOffButton
            // 
            this.SwitchOffButton.FlatAppearance.BorderSize = 0;
            this.SwitchOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchOffButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchOffButton.ForeColor = System.Drawing.Color.White;
            this.SwitchOffButton.Image = ((System.Drawing.Image)(resources.GetObject("SwitchOffButton.Image")));
            this.SwitchOffButton.Location = new System.Drawing.Point(658, 14);
            this.SwitchOffButton.Name = "SwitchOffButton";
            this.SwitchOffButton.Size = new System.Drawing.Size(49, 36);
            this.SwitchOffButton.TabIndex = 0;
            this.SwitchOffButton.UseVisualStyleBackColor = true;
            this.SwitchOffButton.Click += new System.EventHandler(this.SwitchOffButton_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Controls.Add(this.dashboardUC1);
            this.PanelContainer.Controls.Add(this.changePasswordUC1);
            this.PanelContainer.Location = new System.Drawing.Point(140, 56);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(567, 308);
            this.PanelContainer.TabIndex = 2;
            // 
            // changePasswordUC1
            // 
            this.changePasswordUC1.Location = new System.Drawing.Point(0, 0);
            this.changePasswordUC1.Name = "changePasswordUC1";
            this.changePasswordUC1.Size = new System.Drawing.Size(567, 305);
            this.changePasswordUC1.TabIndex = 1;
            // 
            // dashboardUC1
            // 
            this.dashboardUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardUC1.Location = new System.Drawing.Point(0, 0);
            this.dashboardUC1.Name = "dashboardUC1";
            this.dashboardUC1.Size = new System.Drawing.Size(567, 308);
            this.dashboardUC1.TabIndex = 0;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 363);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.Dashboardlbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SwitchOffButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DashBoardButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Label Dashboardlbl;
        private System.Windows.Forms.Button SwitchOffButton;
        private System.Windows.Forms.Panel PanelContainer;
        private User_Controls.DashboardUC dashboardUC1;
        private User_Controls.ChangePasswordUC changePasswordUC1;
    }
}