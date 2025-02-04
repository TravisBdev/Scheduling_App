namespace Travis_Brown_Scheduling_Application.Forms {
    partial class AddCustomer {
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
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            tbName = new TextBox();
            tbAddress = new TextBox();
            tbPhoneNumber = new MaskedTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(12, 217);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(41, 15);
            lblPhoneNumber.TabIndex = 1;
            lblPhoneNumber.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 129);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 52);
            tbName.Name = "tbName";
            tbName.Size = new Size(197, 23);
            tbName.TabIndex = 3;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(12, 147);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(197, 23);
            tbAddress.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(12, 235);
            tbPhoneNumber.Mask = "(999) 000-0000";
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(197, 23);
            tbPhoneNumber.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(134, 342);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 377);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbAddress);
            Controls.Add(tbName);
            Controls.Add(lblAddress);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblName);
            Name = "AddCustomer";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private TextBox tbName;
        private TextBox tbAddress;
        private MaskedTextBox tbPhoneNumber;
        private Button btnSave;
        private Button btnCancel;
    }
}