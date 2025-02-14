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
        public ModifyAppointment(int appId, int cusId, string appointmentType, DateTime start, DateTime end) {
            InitializeComponent();
            appointmentId = appId;
            customerId = cusId;
            DateTime localStart = TimeZoneInfo.ConvertTimeFromUtc(start, TimeZoneInfo.Local);
            DateTime localEnd = TimeZoneInfo.ConvertTimeFromUtc(end, TimeZoneInfo.Local);

            if (appointmentType == "Online") {
                rbModOnline.Checked = true;
            } else {
                rbModInPerson.Checked = true;
            }

            dtpModAppDatePicker.Value = localStart.Date;
            cbModAppTimeSelect.SelectedItem = $"{localStart:t} - {localEnd:t}";
        }

        private void btnModSave_Click(object sender, EventArgs e) {
            TimeZoneInfo local = TimeZoneInfo.Local;
            TimeZoneInfo utc = TimeZoneInfo.Utc;
            string appointmentType = rbModOnline.Checked ? "Online" : "In-Person";
            DateTime selectedDate = dtpModAppDatePicker.Value.Date;
            string[] range = cbModAppTimeSelect.SelectedItem.ToString().Split("-");
            DateTime localStart = DateTime.Parse(selectedDate.ToShortDateString() + " " + range[0].Trim());
            DateTime localEnd = DateTime.Parse(selectedDate.ToShortDateString() + " " + range[1].Trim());
            DateTime start = TimeZoneInfo.ConvertTimeToUtc(localStart, local);
            DateTime end = TimeZoneInfo.ConvertTimeToUtc(localEnd, local);

            TimeZoneInfo eastern = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime easternStart = TimeZoneInfo.ConvertTime(start, eastern);
            DateTime easternEnd = TimeZoneInfo.ConvertTime(end, eastern);

            if (easternStart.TimeOfDay < new TimeSpan(9, 0, 0) || easternEnd.TimeOfDay > new TimeSpan(17, 0, 0)) {
                MessageBox.Show("Appointments must be made between 9:00 AM and 5:00 PM EST.", "Whoops", MessageBoxButtons.OK);
                return;
            }

            if (dtpModAppDatePicker.Value.DayOfWeek == DayOfWeek.Saturday || dtpModAppDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) {
                MessageBox.Show("Appointment times are only available Monday through Friday.", "Invalid Date", MessageBoxButtons.OK);
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
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
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

        private void btnModExit_Click(object sender, EventArgs e) {
            this.Hide();
            Appointments appForm = new();
            appForm.ShowDialog();
            this.Close();
        }
    }
}
