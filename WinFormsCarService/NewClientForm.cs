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
    public partial class NewClientForm : Form
    {
        public NewClientForm()
        {
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            string fName = textBoxNume.Text.ToString();
            string lName = textBoxPrenume.Text.ToString();
            string addrs = textBoxAdresa.Text.ToString();
            string loc = textBoxLocalitate.Text.ToString();
            string county = textBoxJudet.Text.ToString();
            string phoneNr = textBoxTelefon.Text.ToString();
            string email = textBoxEmail.Text.ToString();

            client.Nume = fName;
            client.Prenume = lName;
            client.Adresa = addrs;
            client.Localitate = loc;
            client.Judet = county;
            client.Telefon = phoneNr;
            client.Email = email;

            try
            {
                CarServiceAPI.AddClient(client);
                MessageBox.Show("Clientul " + client.Nume + " " + client.Prenume + " a fost adaugat cu succes!");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                this.Close();
            }
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBoxPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLocalitate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxJudet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
