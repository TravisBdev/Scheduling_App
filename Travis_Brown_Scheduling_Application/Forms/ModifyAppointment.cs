using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travis_Brown_Scheduling_Application.Forms {
    public partial class ModifyAppointment : Form {
        private int appointmentId;
        private int customerId;
        public ModifyAppointment(int appId, int cusId, string appointmentType, DateTime start) {
            InitializeComponent();
            appointmentId = appId;
            customerId = cusId;
            DateTime localStart = TimeZoneInfo.ConvertTimeFromUtc(start, TimeZoneInfo.Local);

            if (appointmentType == "Online") {
                rbModOnline.Checked = true;
            } else {
                rbModInPerson.Checked = true;
            }

            dtpModAppDatePicker.Value = localStart.Date;
            dtpModAppStart.Value = localStart;
        }

        private void btnModSave_Click(object sender, EventArgs e) {
            TimeZoneInfo easternTime = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            string appointmentType = rbModOnline.Checked ? "Online" : "In-Person";

            DateTime selectedDate = dtpModAppDatePicker.Value.Date;
            TimeSpan selectedTime = dtpModAppStart.Value.TimeOfDay;

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
            DateTime utcEnd = TimeZoneInfo.ConvertTimeToUtc(easternEnd, easternTime);



            if (easternStart.TimeOfDay < new TimeSpan(9, 0, 0) || easternEnd.TimeOfDay > new TimeSpan(17, 0, 0)) {
                MessageBox.Show("Appointments must be scheduled between 9:00 AM and 5:00 PM ET", "Select New Time", MessageBoxButtons.OK);
                return;
            }

            if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday) {
                MessageBox.Show("Appointment times are only available Monday through Friday.", "Invalid Date", MessageBoxButtons.OK);
                return;
            }

            if(IsOverlap(customerId, appointmentId, utcStart, utcEnd)) {
                return;
            }

            string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";

            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();

                string query = @"
                    UPDATE appointment
                    SET type = @type, start = @start, end = @end, lastUpdate = NOW(), lastUpdateBy = 'admin'
                    WHERE appointmentId = @appointmentId";

                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@type", appointmentType);
                cmd.Parameters.AddWithValue("@start", utcStart);
                cmd.Parameters.AddWithValue("@end", utcEnd);
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                cmd.ExecuteNonQuery();
                this.Hide();
                Appointments appForm = new();
                appForm.ShowDialog();
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private bool IsOverlap(int customerId, int appointmentId, DateTime startTime, DateTime endTime) {
            string connectionString = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";

            using MySqlConnection conn = new(connectionString);

            try {
                conn.Open();
                string query = @"
                    SELECT COUNT(*) FROM appointment
                    WHERE  customerId = @customerId
                    AND appointmentId != @appointmentId
                    AND (start BETWEEN @startTime AND @endTime
                        OR end BETWEEN @startTime AND @endTime
                        OR (@startTime BETWEEN start AND end))";

                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@startTime", startTime);
                cmd.Parameters.AddWithValue("@endTime", endTime);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

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

        private void btnModExit_Click(object sender, EventArgs e) {
            this.Hide();
            Appointments appForm = new();
            appForm.ShowDialog();
            this.Close();
        }
    }
}
