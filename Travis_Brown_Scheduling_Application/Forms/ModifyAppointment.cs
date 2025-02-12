﻿using MySql.Data.MySqlClient;
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

            if (appointmentType == "Online") {
                rbModOnline.Checked = true;
            } else {
                rbModInPerson.Checked = true;
            }

            dtpModAppDatePicker.Value = start.Date;
            cbModAppTimeSelect.SelectedItem = $"{start:t} - {end:t}";
        }

        private void btnModSave_Click(object sender, EventArgs e) {
            string appointmentType = rbModOnline.Checked ? "Online" : "In-Person";
            DateTime selectedDate = dtpModAppDatePicker.Value.Date;
            string[] range = cbModAppTimeSelect.SelectedItem.ToString().Split("-");
            DateTime start = DateTime.Parse(selectedDate.ToShortDateString() + " " + range[0].Trim());
            DateTime end = DateTime.Parse(selectedDate.ToShortDateString() + " " + range[1].Trim());

            if (dtpModAppDatePicker.Value.DayOfWeek == DayOfWeek.Saturday || dtpModAppDatePicker.Value.DayOfWeek == DayOfWeek.Sunday) {
                MessageBox.Show("Appointment times are only available Monday through Friday.", "Invalid Date", MessageBoxButtons.OK);
                return;
            }

            string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";

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
