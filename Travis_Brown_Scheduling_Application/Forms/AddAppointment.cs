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
                dgvAppCustomerList.DataSource = dt;

            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void AddAppointment_Load(object sender, EventArgs e) {
            PopulateCustomersList();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            TimeZoneInfo easternTime = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
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


            int customerId = Convert.ToInt32(dgvAppCustomerList.SelectedRows[0].Cells["customer_Id"].Value);
            string appointmentType = rbOnline.Checked ? "Online" : "In-Person";

            DateTime selectedDate = dtpAppDaySelect.Value.Date;
            TimeSpan selectedTime = dtpAppStart.Value.TimeOfDay;
            DateTime localStart = selectedDate.Add(selectedTime);

            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            DateTime utcStart = TimeZoneInfo.ConvertTimeToUtc(localStart, localTimeZone);
            DateTime easternStart = TimeZoneInfo.ConvertTimeFromUtc(utcStart, easternTime);
            DateTime easternEnd = new DateTime(
                    easternStart.Year,
                    easternStart.Month,
                    easternStart.Day,
                    easternStart.Hour + 1,
                    0,
                    0
                );


            if (easternStart.TimeOfDay < new TimeSpan(9, 0, 0) || easternEnd.TimeOfDay > new TimeSpan(17, 0, 0)) {
                MessageBox.Show("Appointments must be scheduled between 9:00 AM and 5:00 PM ET", "Select New Time", MessageBoxButtons.OK);
                return;
            }

            DateTime utcEnd = TimeZoneInfo.ConvertTimeToUtc(easternEnd, easternTime);
            


            if (IsOverlap(customerId, utcStart, utcEnd)) {
                return;
            }

            string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";

            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();
                int userId = LoggedInUser.UserId;
                string title = "Appointment";
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
                cmd.Parameters.AddWithValue("@start", utcStart);
                cmd.Parameters.AddWithValue("@end", utcEnd);

                cmd.ExecuteNonQuery();
                this.Hide();
                Appointments appointmentsForm = new();
                appointmentsForm.ShowDialog();
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private bool IsOverlap( int customerId, DateTime startTime, DateTime endTime) {
            string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";

            using MySqlConnection conn = new(connectionString);

            try {
                conn.Open();
                string query = @"
                    SELECT COUNT(*) FROM appointment
                    WHERE  customerId = @customerId
                    AND (start BETWEEN @startTime AND @endTime
                        OR end BETWEEN @startTime AND @endTime
                        OR (@startTime BETWEEN start AND end))";

                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@startTime", startTime);
                cmd.Parameters.AddWithValue("@endTime", endTime);
                cmd.Parameters.AddWithValue("@customerId", customerId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0) {
                    MessageBox.Show("Your selection overlaps with an existing appointment.", "Please choose another time.", MessageBoxButtons.OK);
                    return true;
                }

            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }

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
