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
    public partial class Customers : Form {
        public Customers() {
            InitializeComponent();
        }

        private void PopulateCustomersList() {
            string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";
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
    }
}
