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
    public partial class Appointments : Form {
        public Appointments() {
            InitializeComponent();
        }

        private void PopulateAppointmentsList() {
            string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";

            using MySqlConnection conn = new(connectionString);

            try {
                conn.Open();
                string query = @"
                    SELECT 
                    a.appointmentId,
                    c.customerName,
                    a.type,
                    a.start,
                    a.end
                    FROM appointment a
                    JOIN customer c ON a.customerId = c.customerId;";

                using MySqlCommand cmd = new(query, conn);
                using MySqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                dgvAllAppointments.DataSource = dt;

            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void Appointments_Load(object sender, EventArgs e) {
            PopulateAppointmentsList();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e) {
            this.Hide();
            Customers customersForm = new();
            customersForm.ShowDialog();
            this.Close();
        }

    }
}
