namespace Travis_Brown_Scheduling_Application.Forms {
    partial class Directory {
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
            btnDirectCustomers = new Button();
            btnDirectAppointments = new Button();
            SuspendLayout();
            // 
            // btnDirectCustomers
            // 
            btnDirectCustomers.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnDirectCustomers.Location = new Point(100, 38);
            btnDirectCustomers.Name = "btnDirectCustomers";
            btnDirectCustomers.Size = new Size(195, 81);
            btnDirectCustomers.TabIndex = 0;
            btnDirectCustomers.Text = "Customers";
            btnDirectCustomers.UseVisualStyleBackColor = true;
            // 
            // btnDirectAppointments
            // 
            btnDirectAppointments.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnDirectAppointments.Location = new Point(100, 169);
            btnDirectAppointments.Name = "btnDirectAppointments";
            btnDirectAppointments.Size = new Size(195, 81);
            btnDirectAppointments.TabIndex = 1;
            btnDirectAppointments.Text = "Appointments";
            btnDirectAppointments.UseVisualStyleBackColor = true;
            // 
            // Directory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 294);
            Controls.Add(btnDirectAppointments);
            Controls.Add(btnDirectCustomers);
            Name = "Directory";
            Text = "Directory";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDirectCustomers;
        private Button btnDirectAppointments;
    }
}