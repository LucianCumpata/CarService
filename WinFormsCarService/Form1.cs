using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarService;

namespace WinFormsCarService
{
    public partial class CarServiceForm : Form
    {
        public CarServiceForm()
        {
            InitializeComponent();
            
        }

        private void buttonTestData_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string fName = textBoxNume.Text.ToString();
            string lName = textBoxPrenume.Text.ToString();
            string addrs = textBoxAdresa.Text.ToString();
            string loc = textBoxLocalitate.Text.ToString();
            string county = textBoxJudet.Text.ToString();
            string phoneNr = textBoxTelefon.Text.ToString();
            string email = textBoxEmail.Text.ToString();
            

            Core.AddClient(fName, lName, addrs, loc, county, phoneNr, email);
            
           
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
