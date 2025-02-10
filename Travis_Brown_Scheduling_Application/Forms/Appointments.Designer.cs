namespace Travis_Brown_Scheduling_Application.Forms {
    partial class Appointments {
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
            dgvAllAppointments = new DataGridView();
            appointment_id = new DataGridViewTextBoxColumn();
            customer_name = new DataGridViewTextBoxColumn();
            appointment_type = new DataGridViewTextBoxColumn();
            appointment_start = new DataGridViewTextBoxColumn();
            appointment_end = new DataGridViewTextBoxColumn();
            mcalAppointmentPicker = new MonthCalendar();
            label1 = new Label();
            label2 = new Label();
            btnAddAppointment = new Button();
            btnModAppointment = new Button();
            btnAppsExit = new Button();
            btnDeleteAppointment = new Button();
            label3 = new Label();
            cbAppMonths = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            btnViewSchedule = new Button();
            label6 = new Label();
            btnTotalApps = new Button();
            textBox1 = new TextBox();
            btnViewCustomers = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllAppointments).BeginInit();
            SuspendLayout();
            // 
            // dgvAllAppointments
            // 
            dgvAllAppointments.AllowUserToAddRows = false;
            dgvAllAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllAppointments.Columns.AddRange(new DataGridViewColumn[] { appointment_id, customer_name, appointment_type, appointment_start, appointment_end });
            dgvAllAppointments.Location = new Point(12, 27);
            dgvAllAppointments.Name = "dgvAllAppointments";
            dgvAllAppointments.RowHeadersVisible = false;
            dgvAllAppointments.Size = new Size(503, 162);
            dgvAllAppointments.TabIndex = 0;
            // 
            // appointment_id
            // 
            appointment_id.DataPropertyName = "appointmentId";
            appointment_id.HeaderText = "ID";
            appointment_id.Name = "appointment_id";
            // 
            // customer_name
            // 
            customer_name.DataPropertyName = "customerName";
            customer_name.HeaderText = "Customer";
            customer_name.Name = "customer_name";
            // 
            // appointment_type
            // 
            appointment_type.DataPropertyName = "type";
            appointment_type.HeaderText = "Type";
            appointment_type.Name = "appointment_type";
            // 
            // appointment_start
            // 
            appointment_start.DataPropertyName = "start";
            appointment_start.HeaderText = "Start";
            appointment_start.Name = "appointment_start";
            // 
            // appointment_end
            // 
            appointment_end.DataPropertyName = "end";
            appointment_end.HeaderText = "End";
            appointment_end.Name = "appointment_end";
            // 
            // mcalAppointmentPicker
            // 
            mcalAppointmentPicker.Location = new Point(568, 27);
            mcalAppointmentPicker.Name = "mcalAppointmentPicker";
            mcalAppointmentPicker.TabIndex = 1;
            mcalAppointmentPicker.DateSelected += mcalAppointmentPicker_DateSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "All Appointments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(568, 9);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Select by Date";
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Location = new Point(12, 195);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(111, 23);
            btnAddAppointment.TabIndex = 4;
            btnAddAppointment.Text = "Add Appointment";
            btnAddAppointment.UseVisualStyleBackColor = true;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // btnModAppointment
            // 
            btnModAppointment.Location = new Point(195, 195);
            btnModAppointment.Name = "btnModAppointment";
            btnModAppointment.Size = new Size(129, 23);
            btnModAppointment.TabIndex = 5;
            btnModAppointment.Text = "Modify Appointment";
            btnModAppointment.UseVisualStyleBackColor = true;
            // 
            // btnAppsExit
            // 
            btnAppsExit.Location = new Point(739, 536);
            btnAppsExit.Name = "btnAppsExit";
            btnAppsExit.Size = new Size(75, 23);
            btnAppsExit.TabIndex = 6;
            btnAppsExit.Text = "Exit";
            btnAppsExit.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Location = new Point(390, 195);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(125, 23);
            btnDeleteAppointment.TabIndex = 7;
            btnDeleteAppointment.Text = "Delete Appointment";
            btnDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(354, 316);
            label3.Name = "label3";
            label3.Size = new Size(87, 30);
            label3.TabIndex = 8;
            label3.Text = "Reports";
            // 
            // cbAppMonths
            // 
            cbAppMonths.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAppMonths.FormattingEnabled = true;
            cbAppMonths.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cbAppMonths.Location = new Point(12, 400);
            cbAppMonths.MaxDropDownItems = 12;
            cbAppMonths.Name = "cbAppMonths";
            cbAppMonths.Size = new Size(131, 23);
            cbAppMonths.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 382);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 10;
            label4.Text = "Select Month";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 382);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Schedule";
            // 
            // btnViewSchedule
            // 
            btnViewSchedule.Location = new Point(354, 400);
            btnViewSchedule.Name = "btnViewSchedule";
            btnViewSchedule.Size = new Size(75, 23);
            btnViewSchedule.TabIndex = 12;
            btnViewSchedule.Text = "View";
            btnViewSchedule.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(682, 382);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 13;
            label6.Text = "Total Appointments";
            // 
            // btnTotalApps
            // 
            btnTotalApps.Location = new Point(682, 400);
            btnTotalApps.Name = "btnTotalApps";
            btnTotalApps.Size = new Size(64, 23);
            btnTotalApps.TabIndex = 14;
            btnTotalApps.Text = "Generate";
            btnTotalApps.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(752, 400);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(39, 23);
            textBox1.TabIndex = 15;
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.Location = new Point(195, 260);
            btnViewCustomers.Name = "btnViewCustomers";
            btnViewCustomers.Size = new Size(125, 23);
            btnViewCustomers.TabIndex = 16;
            btnViewCustomers.Text = "View Customers";
            btnViewCustomers.UseVisualStyleBackColor = true;
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 571);
            Controls.Add(btnViewCustomers);
            Controls.Add(textBox1);
            Controls.Add(btnTotalApps);
            Controls.Add(label6);
            Controls.Add(btnViewSchedule);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbAppMonths);
            Controls.Add(label3);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(btnAppsExit);
            Controls.Add(btnModAppointment);
            Controls.Add(btnAddAppointment);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mcalAppointmentPicker);
            Controls.Add(dgvAllAppointments);
            Name = "Appointments";
            Text = "Appointments";
            Load += Appointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllAppointments;
        private MonthCalendar mcalAppointmentPicker;
        private Label label1;
        private Label label2;
        private Button btnAddAppointment;
        private Button btnModAppointment;
        private Button btnAppsExit;
        private Button btnDeleteAppointment;
        private Label label3;
        private ComboBox cbAppMonths;
        private Label label4;
        private Label label5;
        private Button btnViewSchedule;
        private Label label6;
        private Button btnTotalApps;
        private TextBox textBox1;
        private Button btnViewCustomers;
        private DataGridViewTextBoxColumn appointment_id;
        private DataGridViewTextBoxColumn customer_name;
        private DataGridViewTextBoxColumn appointment_type;
        private DataGridViewTextBoxColumn appointment_start;
        private DataGridViewTextBoxColumn appointment_end;
    }
}