namespace Travis_Brown_Scheduling_Application.Forms {
    partial class Customers {
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
            dgvCustomersList = new DataGridView();
            customer_Id = new DataGridViewTextBoxColumn();
            customer_Name = new DataGridViewTextBoxColumn();
            customer_address = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            btnAddCustomer = new Button();
            btnModifyCustomer = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnViewAppointments = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersList).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomersList
            // 
            dgvCustomersList.AllowUserToAddRows = false;
            dgvCustomersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomersList.Columns.AddRange(new DataGridViewColumn[] { customer_Id, customer_Name, customer_address, phone_number });
            dgvCustomersList.Location = new Point(78, 12);
            dgvCustomersList.MultiSelect = false;
            dgvCustomersList.Name = "dgvCustomersList";
            dgvCustomersList.RowHeadersVisible = false;
            dgvCustomersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomersList.Size = new Size(404, 150);
            dgvCustomersList.TabIndex = 0;
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
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(78, 186);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(108, 23);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnModifyCustomer
            // 
            btnModifyCustomer.Location = new Point(373, 186);
            btnModifyCustomer.Name = "btnModifyCustomer";
            btnModifyCustomer.Size = new Size(109, 23);
            btnModifyCustomer.TabIndex = 2;
            btnModifyCustomer.Text = "Modify Customer";
            btnModifyCustomer.UseVisualStyleBackColor = true;
            btnModifyCustomer.Click += btnModifyCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(584, 261);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(502, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(502, 104);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnViewAppointments
            // 
            btnViewAppointments.Location = new Point(228, 242);
            btnViewAppointments.Name = "btnViewAppointments";
            btnViewAppointments.Size = new Size(120, 23);
            btnViewAppointments.TabIndex = 6;
            btnViewAppointments.Text = "View Appointments";
            btnViewAppointments.UseVisualStyleBackColor = true;
            btnViewAppointments.Click += btnViewAppointments_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 296);
            Controls.Add(btnViewAppointments);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnModifyCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(dgvCustomersList);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomersList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomersList;
        private Button btnAddCustomer;
        private Button btnModifyCustomer;
        private Button btnExit;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnViewAppointments;
        private DataGridViewTextBoxColumn customer_Id;
        private DataGridViewTextBoxColumn customer_Name;
        private DataGridViewTextBoxColumn customer_address;
        private DataGridViewTextBoxColumn phone_number;
    }
}