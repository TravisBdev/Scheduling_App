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

namespace Travis_Brown_Scheduling_Application.Forms {
    public partial class ModifyCustomer : Form {
        private int customerId;
        private int addressId;
        public ModifyCustomer(int id, int addId, string name, string address, string phone) {
            InitializeComponent();
            customerId = id;
            tbModName.Text = name;
            addressId = addId;
            tbModAddress.Text = address;
            tbModPhone.Text = phone;
        }

        private void btnModSave_Click(object sender, EventArgs e) {
            string modName = tbModName.Text.Trim();
            string modAddress = tbModAddress.Text.Trim();
            string modPhone = tbModPhone.Text.Trim();

            if(string.IsNullOrEmpty(modName) || string.IsNullOrEmpty(modAddress) || string.IsNullOrEmpty(modPhone)) {
                MessageBox.Show("All fields required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";

            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();

                string customerQuery = @"
                    UPDATE customer
                    SET customerName = @name, lastUpdate = NOW(), lastUpdateBy = 'admin'
                    WHERE customerId = @id";

                using MySqlCommand customerCmd = new(customerQuery, conn);
                customerCmd.Parameters.AddWithValue("@name", modName);
                customerCmd.Parameters.AddWithValue("@id", customerId);
                customerCmd.ExecuteNonQuery();

                string addressQuery = @"
                    UPDATE address
                    SET address = @address, phone = @phone, lastUpdate = NOW(), lastUpdateBy = 'admin'
                    WHERE addressId = @addressId";

                using MySqlCommand addressCmd = new(addressQuery, conn);
                addressCmd.Parameters.AddWithValue("@address", modAddress);
                addressCmd.Parameters.AddWithValue("@phone", modPhone);
                addressCmd.Parameters.AddWithValue("@addressId", addressId);

                addressCmd.ExecuteNonQuery();

                this.Close();
            } catch(MySqlException sqlx) {
                MessageBox.Show($"Error: {sqlx.Message}", "Database error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
