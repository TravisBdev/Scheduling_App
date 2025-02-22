﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travis_Brown_Scheduling_Application.Forms {
    public partial class Customers : Form {
        public Customers() {
            InitializeComponent();
        }

        private void PopulateCustomersList() {
            string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";
            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();
                string query = @"
                    SELECT
                    c.customerId,
                    c.customerName,
                    a.address,
                    a.phone
                    FROM customer c
                    JOIN address a ON c.addressId = a.addressId;";

                using MySqlCommand cmd = new(query, conn);
                using MySqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                dgvCustomersList.DataSource = dt;

            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnViewAppointments_Click(object sender, EventArgs e) {
            this.Hide();
            Appointments appointmentsForm = new();
            appointmentsForm.ShowDialog();
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e) {
            this.Hide();
            AddCustomer addCustomerForm = new();
            addCustomerForm.ShowDialog();
            this.Close();
        }

        private void Customers_Load(object sender, EventArgs e) {
            PopulateCustomersList();
        }

        private void btnModifyCustomer_Click(object sender, EventArgs e) {
            if (dgvCustomersList.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a customer to modify.");
                return;
            }

            DataGridViewRow selected = dgvCustomersList.SelectedRows[0];
            int customerId = Convert.ToInt32(selected.Cells["customer_Id"].Value);
            string customerName = selected.Cells["customer_Name"].Value.ToString();
            string address = selected.Cells["customer_address"].Value.ToString();
            string phone = selected.Cells["phone_number"].Value.ToString();

            //Placeholder value so the compiler doesn't throw an error.
            int addressId = -1;

            string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";

            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();

                string query = "SELECT addressId FROM customer WHERE customerId = @customerId";
                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                object res = cmd.ExecuteScalar();
                if (res != null) {
                    addressId = Convert.ToInt32(res);
                }
            } catch (MySqlException sqlx) {
                MessageBox.Show($"Error: {sqlx.Message}", "Database error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }

            ModifyCustomer modCustomerForm = new(customerId, addressId, customerName, address, phone);
            this.Hide();
            modCustomerForm.ShowDialog();
            PopulateCustomersList();
            this.Show();
        }


        /*
            Delete customer and associated appointments. May need to be tested later as the appointments functionality has yet to be created.
         */
        private void btnDelete_Click(object sender, EventArgs e) {
            if(dgvCustomersList.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a customer to remove.");
            }

            DataGridViewRow selected = dgvCustomersList.SelectedRows[0];
            int customerId = Convert.ToInt32(selected.Cells["customer_id"].Value);
            //Another placeholder for the compiler
            int addressId = -1;

            string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";

            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();

                var selection = MessageBox.Show("Deleting this customer will also remove any associated appointments.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (selection == DialogResult.Yes) {
                    this.Close();
                } else {
                    return;
                }

                string addressQuery = "SELECT addressId FROM customer WHERE customerId = customerId";
                using MySqlCommand addressCmd = new(addressQuery, conn);
                addressCmd.Parameters.AddWithValue("customerId", customerId);
                object res = addressCmd.ExecuteScalar();
                if(res != null) {
                    addressId = Convert.ToInt32(res);
                }

                //Delete Appointments
                string deleteAppQuery = "DELETE FROM appointment WHERE customerId = @customerId";
                using MySqlCommand deleteAppCmd = new(deleteAppQuery, conn);
                deleteAppCmd.Parameters.AddWithValue("customerId", customerId);
                deleteAppCmd.ExecuteNonQuery();

                //Delete Customer
                string deleteCustomerQuery = "DELETE FROM customer WHERE customerId = @customerId";
                using MySqlCommand deleteCusCmd = new(deleteCustomerQuery, conn);
                deleteCusCmd.Parameters.AddWithValue("@customerId", customerId);
                deleteCusCmd.ExecuteNonQuery();


                //Delete Address
                if(addressId != -1) {
                    string deleteAddressQuery = "DELETE FROM address WHERE addressId = @addressId";
                    using MySqlCommand deleteAddressCmd = new(deleteAddressQuery, conn);
                    deleteAddressCmd.Parameters.AddWithValue("@addressId", addressId);
                    deleteAddressCmd.ExecuteNonQuery();
                }

                PopulateCustomersList();



            } catch(Exception ex) { }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Hide();
            DirectoryForm directory = new();
            directory.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            var res = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) {
                this.Close();
            } else {
                return;
            }
        }
    }
}
