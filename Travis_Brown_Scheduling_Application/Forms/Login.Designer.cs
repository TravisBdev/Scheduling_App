namespace Travis_Brown_Scheduling_Application
{
    partial class Login
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
        private void InitializeComponent() {
            lblLoginTitle = new Label();
            tbLoginUserName = new TextBox();
            tbLoginPassword = new TextBox();
            btnLoginSubmit = new Button();
            lblLoginUserName = new Label();
            lblLoginPassword = new Label();
            SuspendLayout();
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Calibri", 20F, FontStyle.Bold);
            lblLoginTitle.Location = new Point(180, 9);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(75, 33);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Login";
            // 
            // tbLoginUserName
            // 
            tbLoginUserName.Location = new Point(128, 117);
            tbLoginUserName.Name = "tbLoginUserName";
            tbLoginUserName.Size = new Size(181, 23);
            tbLoginUserName.TabIndex = 1;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Location = new Point(128, 215);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.Size = new Size(181, 23);
            tbLoginPassword.TabIndex = 2;
            // 
            // btnLoginSubmit
            // 
            btnLoginSubmit.Location = new Point(180, 300);
            btnLoginSubmit.Name = "btnLoginSubmit";
            btnLoginSubmit.Size = new Size(75, 23);
            btnLoginSubmit.TabIndex = 3;
            btnLoginSubmit.Text = "Submit";
            btnLoginSubmit.UseVisualStyleBackColor = true;
            // 
            // lblLoginUserName
            // 
            lblLoginUserName.AutoSize = true;
            lblLoginUserName.Location = new Point(128, 99);
            lblLoginUserName.Name = "lblLoginUserName";
            lblLoginUserName.Size = new Size(65, 15);
            lblLoginUserName.TabIndex = 4;
            lblLoginUserName.Text = "User Name";
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Location = new Point(128, 197);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(57, 15);
            lblLoginPassword.TabIndex = 5;
            lblLoginPassword.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 383);
            Controls.Add(lblLoginPassword);
            Controls.Add(lblLoginUserName);
            Controls.Add(btnLoginSubmit);
            Controls.Add(tbLoginPassword);
            Controls.Add(tbLoginUserName);
            Controls.Add(lblLoginTitle);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginTitle;
        private TextBox tbLoginUserName;
        private TextBox tbLoginPassword;
        private Button btnLoginSubmit;
        private Label lblLoginUserName;
        private Label lblLoginPassword;
    }
}
