namespace MyPerpus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textUsername = new TextBox();
            textEmail = new TextBox();
            textPhone = new TextBox();
            textIsAdmin = new TextBox();
            textPassword = new TextBox();
            buttonNew = new Button();
            dataGridUser = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            isAdmin = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(68, 34);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(100, 23);
            textUsername.TabIndex = 0;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(68, 128);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 23);
            textEmail.TabIndex = 1;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(68, 177);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(100, 23);
            textPhone.TabIndex = 2;
            // 
            // textIsAdmin
            // 
            textIsAdmin.Location = new Point(68, 236);
            textIsAdmin.Name = "textIsAdmin";
            textIsAdmin.Size = new Size(100, 23);
            textIsAdmin.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(68, 80);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(100, 23);
            textPassword.TabIndex = 4;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(241, 34);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 5;
            buttonNew.Text = "Save";
            buttonNew.UseVisualStyleBackColor = true;
            // 
            // dataGridUser
            // 
            dataGridUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Columns.AddRange(new DataGridViewColumn[] { No, Username, Email, isAdmin });
            dataGridUser.Location = new Point(344, 34);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.Size = new Size(444, 290);
            dataGridUser.TabIndex = 6;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.Name = "No";
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // isAdmin
            // 
            isAdmin.HeaderText = "isAdmin";
            isAdmin.Name = "isAdmin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridUser);
            Controls.Add(buttonNew);
            Controls.Add(textPassword);
            Controls.Add(textIsAdmin);
            Controls.Add(textPhone);
            Controls.Add(textEmail);
            Controls.Add(textUsername);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textEmail;
        private TextBox textPhone;
        private TextBox textIsAdmin;
        private TextBox textPassword;
        private Button buttonNew;
        private DataGridView dataGridUser;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn isAdmin;
    }
}
