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
            Client client = new Client();
            client.Nume = textBoxNume.Text.ToString();
            client.Prenume = textBoxPrenume.Text.ToString();
            client.Adresa = textBoxAdresa.Text.ToString();
            client.Localitate = textBoxLocalitate.Text.ToString();
            client.Judet = textBoxJudet.Text.ToString();
            client.Telefon = textBoxTelefon.Text.ToString();
            client.Email = textBoxEmail.Text.ToString();

            try
            {
                Clients.AddClient(client);
                MessageBox.Show("Client " + client.Nume + " " + client.Prenume + " a fost adaugat cu succes!");
                textBoxNume.Clear();
                textBoxPrenume.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            /*
            string fName = textBoxNume.Text.ToString();
            string lName = textBoxPrenume.Text.ToString();
            string addrs = textBoxAdresa.Text.ToString();
            string loc = textBoxLocalitate.Text.ToString();
            string county = textBoxJudet.Text.ToString();
            string phoneNr = textBoxTelefon.Text.ToString();
            string email = textBoxEmail.Text.ToString();

            
            try
            {
                Clients.Add(fName, lName, addrs, loc, county, phoneNr, email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error");
            }
            */

        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowAllClients_Click(object sender, EventArgs e)
        {
            /*
            string clients = "";
            foreach (var client in Core.ShowClients())
            {
                clients += (client + "\n");
            }
            */

            //MessageBox.Show(Core.ShowClients()[0].Nume);

            MessageBox.Show(Clients.ShowAll());
            
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Clients.Delete(3);
        }

        private void buttonAddMecanic_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeMecanic.Text.ToString();
            string prenume = textBoxPrenumeMecanic.Text.ToString();
            try
            {
                Mecanics.Add(nume,prenume);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
        }

        private void textBoxNumeMecanic_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMecanicUpdate_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeMecanic.Text.ToString();
            string prenume = textBoxPrenumeMecanic.Text.ToString();
            int id = Int32.Parse(textBoxMecanicId.Text.ToString());
            Mecanics.Update(id, nume, prenume);
        }

        private void buttonAddAuto_Click(object sender, EventArgs e)
        {
            string nrAuto = textBoxNumarAuto.Text.ToString();
            string serieSasiu = textBoxSerieSasiu.Text.ToString();
            string codSasiu = textBoxCodSasiu.Text.ToString();
            string denumireSasiu = textBoxDenumireSasiu.Text.ToString();
            int id = Int32.Parse(textBoxIdClient.Text.ToString());
            Automobile.Add(nrAuto, serieSasiu, codSasiu, denumireSasiu, id);
        }

        private void buttonAutoUpdate_Click(object sender, EventArgs e)
        {
            string nrAuto = textBoxNumarAuto.Text.ToString();
            string serieSasiu = textBoxSerieSasiu.Text.ToString();
            string codSasiu = textBoxCodSasiu.Text.ToString();
            string denumireSasiu = textBoxDenumireSasiu.Text.ToString();
            int idClient = Int32.Parse(textBoxIdClient.Text.ToString());
            int id = Int32.Parse(textBoxAutoId.Text.ToString());
            Automobile.Update(id, nrAuto, serieSasiu, codSasiu, denumireSasiu, idClient);

        }

        private void buttonAutoDelete_Click(object sender, EventArgs e)
        {
            Automobile.Delete(Int32.Parse(textBoxAutoId.Text.ToString()));
            
        }
    }
}
