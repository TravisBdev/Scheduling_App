namespace Travis_Brown_Scheduling_Application.Forms {
    partial class ModifyAppointment {
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
            gbModAppType = new GroupBox();
            rbModInPerson = new RadioButton();
            rbModOnline = new RadioButton();
            dtpModAppDatePicker = new DateTimePicker();
            btnModSave = new Button();
            btnModExit = new Button();
            label1 = new Label();
            label2 = new Label();
            dtpModAppStart = new DateTimePicker();
            gbModAppType.SuspendLayout();
            SuspendLayout();
            // 
            // gbModAppType
            // 
            gbModAppType.Controls.Add(rbModInPerson);
            gbModAppType.Controls.Add(rbModOnline);
            gbModAppType.Location = new Point(12, 12);
            gbModAppType.Name = "gbModAppType";
            gbModAppType.Size = new Size(152, 82);
            gbModAppType.TabIndex = 0;
            gbModAppType.TabStop = false;
            gbModAppType.Text = "Appointment Type";
            // 
            // rbModInPerson
            // 
            rbModInPerson.AutoSize = true;
            rbModInPerson.Location = new Point(15, 48);
            rbModInPerson.Name = "rbModInPerson";
            rbModInPerson.Size = new Size(76, 19);
            rbModInPerson.TabIndex = 1;
            rbModInPerson.TabStop = true;
            rbModInPerson.Text = "In-Person";
            rbModInPerson.UseVisualStyleBackColor = true;
            // 
            // rbModOnline
            // 
            rbModOnline.AutoSize = true;
            rbModOnline.Location = new Point(15, 23);
            rbModOnline.Name = "rbModOnline";
            rbModOnline.Size = new Size(60, 19);
            rbModOnline.TabIndex = 0;
            rbModOnline.TabStop = true;
            rbModOnline.Text = "Online";
            rbModOnline.UseVisualStyleBackColor = true;
            // 
            // dtpModAppDatePicker
            // 
            dtpModAppDatePicker.CustomFormat = "dddd, MMM dd yyy";
            dtpModAppDatePicker.Location = new Point(12, 146);
            dtpModAppDatePicker.Name = "dtpModAppDatePicker";
            dtpModAppDatePicker.Size = new Size(200, 23);
            dtpModAppDatePicker.TabIndex = 1;
            // 
            // btnModSave
            // 
            btnModSave.Location = new Point(12, 419);
            btnModSave.Name = "btnModSave";
            btnModSave.Size = new Size(75, 23);
            btnModSave.TabIndex = 3;
            btnModSave.Text = "Save";
            btnModSave.UseVisualStyleBackColor = true;
            btnModSave.Click += btnModSave_Click;
            // 
            // btnModExit
            // 
            btnModExit.Location = new Point(238, 419);
            btnModExit.Name = "btnModExit";
            btnModExit.Size = new Size(75, 23);
            btnModExit.TabIndex = 4;
            btnModExit.Text = "Exit";
            btnModExit.UseVisualStyleBackColor = true;
            btnModExit.Click += btnModExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 5;
            label1.Text = "Select Day (Mon-Fri)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 258);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Select Time";
            // 
            // dtpModAppStart
            // 
            dtpModAppStart.CustomFormat = "hh:mm tt";
            dtpModAppStart.Format = DateTimePickerFormat.Custom;
            dtpModAppStart.Location = new Point(12, 276);
            dtpModAppStart.Name = "dtpModAppStart";
            dtpModAppStart.ShowUpDown = true;
            dtpModAppStart.Size = new Size(200, 23);
            dtpModAppStart.TabIndex = 7;
            // 
            // ModifyAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 454);
            Controls.Add(dtpModAppStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModExit);
            Controls.Add(btnModSave);
            Controls.Add(dtpModAppDatePicker);
            Controls.Add(gbModAppType);
            Name = "ModifyAppointment";
            Text = "ModifyAppointment";
            gbModAppType.ResumeLayout(false);
            gbModAppType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbModAppType;
        private RadioButton rbModInPerson;
        private RadioButton rbModOnline;
        private DateTimePicker dtpModAppDatePicker;
        private Button btnModSave;
        private Button btnModExit;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpModAppStart;
    }
}