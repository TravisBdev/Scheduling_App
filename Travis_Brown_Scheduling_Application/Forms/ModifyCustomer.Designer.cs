namespace Travis_Brown_Scheduling_Application.Forms {
    partial class ModifyCustomer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblName = new Label();
            lblAddress = new Label();
            lblPhoneNumber = new Label();
            btnModSave = new Button();
            btnModExit = new Button();
            tbModName = new TextBox();
            tbModAddress = new TextBox();
            tbModPhoneNumber = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 133);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(12, 225);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(41, 15);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone";
            // 
            // btnModSave
            // 
            btnModSave.Location = new Point(12, 346);
            btnModSave.Name = "btnModSave";
            btnModSave.Size = new Size(75, 23);
            btnModSave.TabIndex = 3;
            btnModSave.Text = "Save";
            btnModSave.UseVisualStyleBackColor = true;
            // 
            // btnModExit
            // 
            btnModExit.Location = new Point(150, 346);
            btnModExit.Name = "btnModExit";
            btnModExit.Size = new Size(75, 23);
            btnModExit.TabIndex = 4;
            btnModExit.Text = "Exit";
            btnModExit.UseVisualStyleBackColor = true;
            // 
            // tbModName
            // 
            tbModName.Location = new Point(12, 55);
            tbModName.Name = "tbModName";
            tbModName.Size = new Size(200, 23);
            tbModName.TabIndex = 5;
            // 
            // tbModAddress
            // 
            tbModAddress.Location = new Point(12, 151);
            tbModAddress.Name = "tbModAddress";
            tbModAddress.Size = new Size(200, 23);
            tbModAddress.TabIndex = 6;
            // 
            // tbModPhoneNumber
            // 
            tbModPhoneNumber.Location = new Point(12, 243);
            tbModPhoneNumber.Name = "tbModPhoneNumber";
            tbModPhoneNumber.Size = new Size(200, 23);
            tbModPhoneNumber.TabIndex = 7;
            // 
            // ModifyCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 381);
            Controls.Add(tbModPhoneNumber);
            Controls.Add(tbModAddress);
            Controls.Add(tbModName);
            Controls.Add(btnModExit);
            Controls.Add(btnModSave);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Name = "ModifyCustomer";
            Text = "Modify Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAddress;
        private Label lblPhoneNumber;
        private Button btnModSave;
        private Button btnModExit;
        private TextBox tbModName;
        private TextBox tbModAddress;
        private MaskedTextBox tbModPhoneNumber;
    }
}