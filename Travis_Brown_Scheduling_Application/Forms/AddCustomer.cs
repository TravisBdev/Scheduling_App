using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Travis_Brown_Scheduling_Application.Forms {
    public partial class AddCustomer : Form {
        public AddCustomer() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string customerName = tbName.Text.Trim();
            string address = tbAddress.Text.Trim();
            string phone = tbPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone)) {
                MessageBox.Show("All fields required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!tbPhoneNumber.MaskFull) {
                tbPhoneNumber.BackColor = Color.Red;
                ttpPhoneValid.Show("Please enter 10 digits.", tbPhoneNumber, 0, tbPhoneNumber.Height, 1500);
                return;
            } else {
                tbPhoneNumber.BackColor = Color.White;
                ttpPhoneValid.Hide(tbPhoneNumber);
            }

            string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";

            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();

                string addressQuery = @"
                INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)
                VALUES (@address, '', 1, '', @phone, Now(), 'admin', NOW(), 'admin');
                SELECT LAST_INSERT_ID();";

                using MySqlCommand cmd = new(addressQuery, conn);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);

                int addressId = Convert.ToInt32(cmd.ExecuteScalar());

                //potential null check if needed
                //object res = cmd.ExecuteScalar();
                //if(res == null || res == DBNull.Value) {
                //    Console.WriteLine("Could not insert.");
                //    return;
                //}

                string customerQuery = @"
                    INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                    VALUES (@customerName, @addressId, 1, NOW(), 'admin', NOW(), 'admin');
                    ";

                using MySqlCommand cusCmd = new(customerQuery, conn);
                cusCmd.Parameters.AddWithValue("@customerName", customerName);
                cusCmd.Parameters.AddWithValue("@addressId", addressId);

                cusCmd.ExecuteNonQuery();
                this.Close();

            } catch(MySqlException sqlx) {
                MessageBox.Show($"Error: {sqlx.Message}", "Database error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
            //this.Hide();
            //Customers customersForm = new();
            //customersForm.ShowDialog();
            //this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            Customers customersForm = new();
            customersForm.ShowDialog();
            this.Close();
        }
    }
}
