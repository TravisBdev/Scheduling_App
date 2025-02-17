namespace Travis_Brown_Scheduling_Application.Forms {
    partial class AddAppointment {
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
            gbAppointmentType = new GroupBox();
            rbInPerson = new RadioButton();
            rbOnline = new RadioButton();
            dgvAppCustomerList = new DataGridView();
            customer_Id = new DataGridViewTextBoxColumn();
            customer_Name = new DataGridViewTextBoxColumn();
            customer_address = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dtpAppDaySelect = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            dtpAppStart = new DateTimePicker();
            gbAppointmentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppCustomerList).BeginInit();
            SuspendLayout();
            // 
            // gbAppointmentType
            // 
            gbAppointmentType.Controls.Add(rbInPerson);
            gbAppointmentType.Controls.Add(rbOnline);
            gbAppointmentType.Location = new Point(12, 12);
            gbAppointmentType.Name = "gbAppointmentType";
            gbAppointmentType.Size = new Size(140, 73);
            gbAppointmentType.TabIndex = 0;
            gbAppointmentType.TabStop = false;
            gbAppointmentType.Text = "Appointment Type";
            // 
            // rbInPerson
            // 
            rbInPerson.AutoSize = true;
            rbInPerson.Location = new Point(18, 46);
            rbInPerson.Name = "rbInPerson";
            rbInPerson.Size = new Size(76, 19);
            rbInPerson.TabIndex = 1;
            rbInPerson.TabStop = true;
            rbInPerson.Text = "In-Person";
            rbInPerson.UseVisualStyleBackColor = true;
            // 
            // rbOnline
            // 
            rbOnline.AutoSize = true;
            rbOnline.Location = new Point(18, 21);
            rbOnline.Name = "rbOnline";
            rbOnline.Size = new Size(60, 19);
            rbOnline.TabIndex = 0;
            rbOnline.TabStop = true;
            rbOnline.Text = "Online";
            rbOnline.UseVisualStyleBackColor = true;
            // 
            // dgvAppCustomerList
            // 
            dgvAppCustomerList.AllowUserToAddRows = false;
            dgvAppCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppCustomerList.Columns.AddRange(new DataGridViewColumn[] { customer_Id, customer_Name, customer_address, phone_number });
            dgvAppCustomerList.Location = new Point(385, 33);
            dgvAppCustomerList.MultiSelect = false;
            dgvAppCustomerList.Name = "dgvAppCustomerList";
            dgvAppCustomerList.RowHeadersVisible = false;
            dgvAppCustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppCustomerList.Size = new Size(403, 274);
            dgvAppCustomerList.TabIndex = 1;
            // 
            // customer_Id
            // 
            customer_Id.DataPropertyName = "customerId";
            customer_Id.HeaderText = "ID";
            customer_Id.Name = "customer_Id";
            // 
            // customer_Name
            // 
            customer_Name.DataPropertyName = "customerName";
            customer_Name.HeaderText = "Name";
            customer_Name.Name = "customer_Name";
            // 
            // customer_address
            // 
            customer_address.DataPropertyName = "address";
            customer_address.HeaderText = "Address";
            customer_address.Name = "customer_address";
            // 
            // phone_number
            // 
            phone_number.DataPropertyName = "phone";
            phone_number.HeaderText = "Phone";
            phone_number.Name = "phone_number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 15);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Select Customer";
            // 
            // dtpAppDaySelect
            // 
            dtpAppDaySelect.CustomFormat = "dddd, MMM dd yyy";
            dtpAppDaySelect.Format = DateTimePickerFormat.Custom;
            dtpAppDaySelect.Location = new Point(12, 160);
            dtpAppDaySelect.Name = "dtpAppDaySelect";
            dtpAppDaySelect.Size = new Size(200, 23);
            dtpAppDaySelect.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 4;
            label2.Text = "Select Day (Mon-Fri)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 266);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Select Time";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(713, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpAppStart
            // 
            dtpAppStart.CustomFormat = "hh:mm tt";
            dtpAppStart.Format = DateTimePickerFormat.Custom;
            dtpAppStart.Location = new Point(12, 284);
            dtpAppStart.Name = "dtpAppStart";
            dtpAppStart.Size = new Size(200, 23);
            dtpAppStart.TabIndex = 9;
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpAppStart);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpAppDaySelect);
            Controls.Add(label1);
            Controls.Add(dgvAppCustomerList);
            Controls.Add(gbAppointmentType);
            Name = "AddAppointment";
            Text = "Add Appointment";
            Load += AddAppointment_Load;
            gbAppointmentType.ResumeLayout(false);
            gbAppointmentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbAppointmentType;
        private RadioButton rbInPerson;
        private RadioButton rbOnline;
        private DataGridView dgvAppCustomerList;
        private Label label1;
        private DateTimePicker dtpAppDaySelect;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
        private DataGridViewTextBoxColumn customer_Id;
        private DataGridViewTextBoxColumn customer_Name;
        private DataGridViewTextBoxColumn customer_address;
        private DataGridViewTextBoxColumn phone_number;
        private DateTimePicker dtpAppStart;
    }
}