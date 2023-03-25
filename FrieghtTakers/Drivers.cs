using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreightTakers
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void DriverDOBdatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UserPicBx_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }
    }
}
