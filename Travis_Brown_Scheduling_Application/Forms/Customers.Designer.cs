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
            customerId = new DataGridViewTextBoxColumn();
            customerName = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            btnAddCustomer = new Button();
            btnModifyCustomer = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersList).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomersList
            // 
            dgvCustomersList.AllowUserToAddRows = false;
            dgvCustomersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomersList.Columns.AddRange(new DataGridViewColumn[] { customerId, customerName, address });
            dgvCustomersList.Location = new Point(179, 12);
            dgvCustomersList.MultiSelect = false;
            dgvCustomersList.Name = "dgvCustomersList";
            dgvCustomersList.RowHeadersVisible = false;
            dgvCustomersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomersList.Size = new Size(303, 150);
            dgvCustomersList.TabIndex = 0;
            // 
            // customerId
            // 
            customerId.HeaderText = "ID";
            customerId.Name = "customerId";
            // 
            // customerName
            // 
            customerName.HeaderText = "Name";
            customerName.Name = "customerName";
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.Name = "address";
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
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 296);
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
        private DataGridViewTextBoxColumn customerId;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn address;
        private Button btnAddCustomer;
        private Button btnModifyCustomer;
        private Button btnExit;
    }
}