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
            btnAddCustomer = new Button();
            btnModifyCustomer = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            customer_Id = new DataGridViewTextBoxColumn();
            customer_Name = new DataGridViewTextBoxColumn();
            customer_address = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersList).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomersList
            // 
            dgvCustomersList.AllowUserToAddRows = false;
            dgvCustomersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomersList.Columns.AddRange(new DataGridViewColumn[] { customer_Id, customer_Name, customer_address });
            dgvCustomersList.Location = new Point(179, 12);
            dgvCustomersList.MultiSelect = false;
            dgvCustomersList.Name = "dgvCustomersList";
            dgvCustomersList.RowHeadersVisible = false;
            dgvCustomersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomersList.Size = new Size(303, 150);
            dgvCustomersList.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(179, 240);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(108, 23);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnModifyCustomer
            // 
            btnModifyCustomer.Location = new Point(373, 240);
            btnModifyCustomer.Name = "btnModifyCustomer";
            btnModifyCustomer.Size = new Size(109, 23);
            btnModifyCustomer.TabIndex = 2;
            btnModifyCustomer.Text = "Modify Customer";
            btnModifyCustomer.UseVisualStyleBackColor = true;
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
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 296);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnModifyCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(dgvCustomersList);
            Name = "Customers";
            Text = "Customers";
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
        private DataGridViewTextBoxColumn customer_Id;
        private DataGridViewTextBoxColumn customer_Name;
        private DataGridViewTextBoxColumn customer_address;
    }
}