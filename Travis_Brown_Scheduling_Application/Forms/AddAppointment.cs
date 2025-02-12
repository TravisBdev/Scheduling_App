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
using System.Globalization;
using Travis_Brown_Scheduling_Application.Utils;

namespace Travis_Brown_Scheduling_Application.Forms {
    public partial class AddAppointment : Form {
        public AddAppointment() {
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
                dgvAppCustomerList.DataSource = dt;

            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void AddAppointment_Load(object sender, EventArgs e) {
            PopulateCustomersList();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (dgvAppCustomerList.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a customer.", "Whoops", MessageBoxButtons.OK);
                return;
            }

            if (dtpAppDaySelect.Value.DayOfWeek == DayOfWeek.Saturday || dtpAppDaySelect.Value.DayOfWeek == DayOfWeek.Sunday) {
                MessageBox.Show("Appointment times are only available Monday through Friday.", "Invalid Date", MessageBoxButtons.OK);
                return;
            }

            if (!rbInPerson.Checked && !rbOnline.Checked) {
                MessageBox.Show("Please select an appointment type.", "Whoops", MessageBoxButtons.OK);
                return;
            }

            if (cbAppTimeSelect.SelectedIndex == -1) {
                MessageBox.Show("Please select an appointment time.", "Whoops", MessageBoxButtons.OK);
                return;
            }

            int customerId = Convert.ToInt32(dgvAppCustomerList.SelectedRows[0].Cells["customer_Id"].Value);
            string appointmentType = rbOnline.Checked ? "Online" : "In-Person";
            DateTime dateSelected = dtpAppDaySelect.Value.Date;
            string timeSelected = cbAppTimeSelect.SelectedItem.ToString();

            DateTime startTime = DateTime.MinValue;
            DateTime endTime = DateTime.MinValue;

            switch (timeSelected) {
                case "9:00 AM - 10:00 AM":
                    startTime = DateTime.ParseExact("09:00 AM", "hh:mm tt", CultureInfo.InvariantCulture);
                    endTime = DateTime.ParseExact("10:00 AM", "hh:mm tt", CultureInfo.InvariantCulture);
                    break;
                case "10:30 AM - 11:30 AM":
                    startTime = DateTime.ParseExact("10:30 AM", "hh:mm tt", CultureInfo.InvariantCulture);
                    endTime = DateTime.ParseExact("11:30 AM", "hh:mm tt", CultureInfo.InvariantCulture);
                    break;
                case "1:00 PM - 2:00 PM":
                    startTime = DateTime.ParseExact("01:00 PM", "hh:mm tt", CultureInfo.InvariantCulture);
                    endTime = DateTime.ParseExact("02:00 PM", "hh:mm tt", CultureInfo.InvariantCulture);
                    break;
                case "2:30 PM - 3:30 PM":
                    startTime = DateTime.ParseExact("02:30 PM", "hh:mm tt", CultureInfo.InvariantCulture);
                    endTime = DateTime.ParseExact("03:30 PM", "hh:mm tt", CultureInfo.InvariantCulture);
                    break;
                case "4:00 PM - 5:00 PM":
                    startTime = DateTime.ParseExact("04:00 PM", "hh:mm tt", CultureInfo.InvariantCulture);
                    endTime = DateTime.ParseExact("05:00 PM", "hh:mm tt", CultureInfo.InvariantCulture);
                    break;
                default:
                    MessageBox.Show("Time slot is not valid", "Error", MessageBoxButtons.OK);
                    return;
            }

            startTime = dateSelected.Add(startTime.TimeOfDay);
            endTime = dateSelected.Add(endTime.TimeOfDay);

            if (IsOverlap(startTime, endTime)) {
                return;
            }

            string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";

            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();
                int userId = LoggedInUser.UserId;
                string title = "Appintment";
                string description = "Appointment";
                string location = rbOnline.Checked ? "Online" : "In-Person";
                string contact = "admin";
                string url = "admin";
                string query = @"
                    INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
                    VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, NOW(), 'admin', NOW(), 'admin')";

                using MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@type", appointmentType);
                cmd.Parameters.AddWithValue("@url", url);
                cmd.Parameters.AddWithValue("@start", startTime);
                cmd.Parameters.AddWithValue("@end", endTime);

                cmd.ExecuteNonQuery();
                this.Hide();
                Appointments appointmentsForm = new();
                appointmentsForm.ShowDialog();
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private bool IsOverlap(DateTime startTime, DateTime endTime) {
            string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";

            using MySqlConnection conn = new(connectionString);

            try {
                conn.Open();
                string query = @"
                    SELECT COUNT(*) FROM appointment
                    WHERE (start BETWEEN @startTime AND @endTime
                        OR end BETWEEN @startTime AND @endTime
                        OR (@startTime BETWEEN start AND end))";

                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@startTime", startTime);
                cmd.Parameters.AddWithValue("@endTime", endTime);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0) {
                    MessageBox.Show("Your selection overlaps with an existing appointment.", "Please choose another time.", MessageBoxButtons.OK);
                    return true;
                }

            } catch (Exception ex) { }

            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Hide();
            Appointments appForm = new();
            appForm.ShowDialog();
            this.Close();
        }
    }
}
