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
            mcalAppointmentPicker = new MonthCalendar();
            label1 = new Label();
            label2 = new Label();
            appointment_id = new DataGridViewTextBoxColumn();
            customer_name = new DataGridViewTextBoxColumn();
            appointment_type = new DataGridViewTextBoxColumn();
            appointment_start = new DataGridViewTextBoxColumn();
            appointment_end = new DataGridViewTextBoxColumn();
            btnAddAppointment = new Button();
            btnModAppointment = new Button();
            button3 = new Button();
            btnDeleteAppointment = new Button();
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
            // mcalAppointmentPicker
            // 
            mcalAppointmentPicker.Location = new Point(568, 27);
            mcalAppointmentPicker.Name = "mcalAppointmentPicker";
            mcalAppointmentPicker.TabIndex = 1;
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
            // appointment_id
            // 
            appointment_id.DataPropertyName = "appointmentId";
            appointment_id.HeaderText = "ID";
            appointment_id.Name = "appointment_id";
            // 
            // customer_name
            // 
            customer_name.HeaderText = "Customer";
            customer_name.Name = "customer_name";
            // 
            // appointment_type
            // 
            appointment_type.HeaderText = "Type";
            appointment_type.Name = "appointment_type";
            // 
            // appointment_start
            // 
            appointment_start.HeaderText = "Start";
            appointment_start.Name = "appointment_start";
            // 
            // appointment_end
            // 
            appointment_end.HeaderText = "End";
            appointment_end.Name = "appointment_end";
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Location = new Point(12, 195);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(111, 23);
            btnAddAppointment.TabIndex = 4;
            btnAddAppointment.Text = "Add Appointment";
            btnAddAppointment.UseVisualStyleBackColor = true;
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
            // button3
            // 
            button3.Location = new Point(739, 268);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
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
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 303);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(button3);
            Controls.Add(btnModAppointment);
            Controls.Add(btnAddAppointment);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mcalAppointmentPicker);
            Controls.Add(dgvAllAppointments);
            Name = "Appointments";
            Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)dgvAllAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllAppointments;
        private MonthCalendar mcalAppointmentPicker;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn appointment_id;
        private DataGridViewTextBoxColumn customer_name;
        private DataGridViewTextBoxColumn appointment_type;
        private DataGridViewTextBoxColumn appointment_start;
        private DataGridViewTextBoxColumn appointment_end;
        private Button btnAddAppointment;
        private Button btnModAppointment;
        private Button button3;
        private Button btnDeleteAppointment;
    }
}