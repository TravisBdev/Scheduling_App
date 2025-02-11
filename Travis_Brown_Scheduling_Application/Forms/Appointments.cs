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


        //Will need to add appointments before testing (*tested and working*)
        private void mcalAppointmentPicker_DateSelected(object sender, DateRangeEventArgs e) {
            string dateSelection = e.Start.ToString("yyyy-MM-dd");

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
                    JOIN customer c ON a.customerId = c.customerId
                    WHERE DATE(a.start) = @dateSelection;";

                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@dateSelection", dateSelection);
                using MySqlDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);
                dgvAllAppointments.DataSource = dt;
            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnModAppointment_Click(object sender, EventArgs e) {
            if (dgvAllAppointments.SelectedRows.Count == 0) {
                MessageBox.Show("Please select an appointment.", "Whoops", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow selectedAppointment = dgvAllAppointments.SelectedRows[0];

            int appointmentId = Convert.ToInt32(selectedAppointment.Cells["appointment_Id"].Value);
            string customerName = selectedAppointment.Cells["customer_name"].Value.ToString();
            //Placeholder value so the compiler doesn't throw an error.
            int customerId = -1;
            DateTime start = Convert.ToDateTime(selectedAppointment.Cells["appointment_start"].Value);
            DateTime end = Convert.ToDateTime(selectedAppointment.Cells["appointment_end"].Value);
            string appointmentType = selectedAppointment.Cells["appointment_type"].Value.ToString();

            string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";

            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();
                string query = "SELECT customerId FROM customer WHERE customerName = @customerName";
                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@customerName", customerName);
                object res = cmd.ExecuteScalar();
                if (res != null) {
                    customerId = Convert.ToInt32(res);
                }

            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }

            ModifyAppointment modAppForm = new(appointmentId, customerId, appointmentType, start, end);
            this.Hide();
            modAppForm.ShowDialog();
            PopulateAppointmentsList();
            this.Show();
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e) {
            if (dgvAllAppointments.SelectedRows.Count == 0) {
                MessageBox.Show("Please select an appointment to delete.", "Whoops", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow selectedAppointment = dgvAllAppointments.SelectedRows[0];
            int appointmentId = Convert.ToInt32(selectedAppointment.Cells["appointment_id"].Value);

            DialogResult res = MessageBox.Show("Are you sure you want to delete this appointment?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res == DialogResult.Yes) {
                string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";

                using MySqlConnection conn = new(connectionString);
                try {
                    conn.Open();
                    string query = "DELETE FROM appointment WHERE appointmentId = @appointmentId";

                    using MySqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                    cmd.ExecuteNonQuery();
                    PopulateAppointmentsList();
                }catch(MySqlException sqlx) {
                    MessageBox.Show($"Database error {sqlx.Message}", "Error", MessageBoxButtons.OK);
                    return;
                }catch(Exception ex) {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void btnViewCustomers_Click(object sender, EventArgs e) {
            this.Hide();
            Customers customersForm = new();
            customersForm.ShowDialog();
            this.Close();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e) {
            this.Hide();
            AddAppointment addAppointmentForm = new();
            addAppointmentForm.ShowDialog();
            this.Close();
        }
    }
}
