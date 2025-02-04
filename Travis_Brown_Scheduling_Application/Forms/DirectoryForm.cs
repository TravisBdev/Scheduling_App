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
    public partial class DirectoryForm : Form {
        public DirectoryForm() {
            InitializeComponent();
        }

        private void btnDirectCustomers_Click(object sender, EventArgs e) {
            this.Hide();
            Customers customersForm = new();
            customersForm.ShowDialog();
            this.Close();
        }

        private void btnDirectAppointments_Click(object sender, EventArgs e) {
            this.Hide();
            Appointments appointmentsForm = new();
            appointmentsForm.ShowDialog();
            this.Close();
        }
    }
}
