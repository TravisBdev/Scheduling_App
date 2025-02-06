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
            label1 = new Label();
            Address = new Label();
            label3 = new Label();
            tbModName = new TextBox();
            tbModAddress = new TextBox();
            tbModPhone = new MaskedTextBox();
            btnModSave = new Button();
            btnModCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(12, 132);
            Address.Name = "Address";
            Address.Size = new Size(49, 15);
            Address.TabIndex = 1;
            Address.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // tbModName
            // 
            tbModName.Location = new Point(13, 54);
            tbModName.Name = "tbModName";
            tbModName.Size = new Size(196, 23);
            tbModName.TabIndex = 3;
            // 
            // tbModAddress
            // 
            tbModAddress.Location = new Point(13, 150);
            tbModAddress.Name = "tbModAddress";
            tbModAddress.Size = new Size(196, 23);
            tbModAddress.TabIndex = 4;
            // 
            // tbModPhone
            // 
            tbModPhone.Location = new Point(12, 241);
            tbModPhone.Mask = "999-000-0000";
            tbModPhone.Name = "tbModPhone";
            tbModPhone.Size = new Size(195, 23);
            tbModPhone.TabIndex = 5;
            // 
            // btnModSave
            // 
            btnModSave.Location = new Point(12, 346);
            btnModSave.Name = "btnModSave";
            btnModSave.Size = new Size(75, 23);
            btnModSave.TabIndex = 6;
            btnModSave.Text = "Save";
            btnModSave.UseVisualStyleBackColor = true;
            btnModSave.Click += btnModSave_Click;
            // 
            // btnModCancel
            // 
            btnModCancel.Location = new Point(145, 346);
            btnModCancel.Name = "btnModCancel";
            btnModCancel.Size = new Size(75, 23);
            btnModCancel.TabIndex = 7;
            btnModCancel.Text = "Cancel";
            btnModCancel.UseVisualStyleBackColor = true;
            // 
            // ModifyCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 378);
            Controls.Add(btnModCancel);
            Controls.Add(btnModSave);
            Controls.Add(tbModPhone);
            Controls.Add(tbModAddress);
            Controls.Add(tbModName);
            Controls.Add(label3);
            Controls.Add(Address);
            Controls.Add(label1);
            Name = "ModifyCustomer";
            Text = "Modify Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Address;
        private Label label3;
        private TextBox tbModName;
        private TextBox tbModAddress;
        private MaskedTextBox tbModPhone;
        private Button btnModSave;
        private Button btnModCancel;
    }
}