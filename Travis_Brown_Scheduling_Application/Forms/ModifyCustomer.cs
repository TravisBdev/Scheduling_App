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
        public ModifyCustomer(int id, string name, string address, string phone) {
            InitializeComponent();
            customerId = id;
            tbModName.Text = name;
            tbModAddress.Text = address;
            tbModPhone.Text = phone;
        }
    }
}
