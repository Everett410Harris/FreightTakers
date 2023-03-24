using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrieghtTakers
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void DriversPicBx_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drivers drivers = new Drivers();
            drivers.Show();
        }
    }
}
