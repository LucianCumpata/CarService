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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error");
            }
           
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

            //MessageBox.Show(CarServiceAPI.Clients.ShowAll());
        }

        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Clients.Delete(3);
        }
        

        private void buttonAddMecanic_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeMecanic.Text.ToString();
            string prenume = textBoxPrenumeMecanic.Text.ToString();
            Mecanic m = new Mecanic();
            m.Nume = nume;
            m.Prenume = prenume;

            try
            {
               CarServiceAPI.AddMecanic(m);
               // Mecanics.Add(nume,prenume);
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
            if (textBoxMecanicId.TextLength > 0)
            {
                int id = Int32.Parse(textBoxMecanicId.Text.ToString());
                //m.Id = id;

                Mecanic m = CarServiceAPI.GetMecanicById(id);

                if (textBoxNumeMecanic.TextLength > 0)
                {
                    string nume = textBoxNumeMecanic.Text.ToString();
                    m.Nume = nume;
                }
                else
                {
                    m.Nume = m.Nume;
                }

                if (textBoxPrenumeMecanic.TextLength > 0)
                {
                    string prenume = textBoxPrenumeMecanic.Text.ToString();
                    m.Prenume = prenume;
                }
                else
                {
                    m.Prenume = m.Prenume;
                }
                try
                {
                    CarServiceAPI.UpdateMecanic(m);
                    // Mecanics.Add(nume,prenume);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
        }

        private void buttonAddAuto_Click(object sender, EventArgs e)
        {
            
            string nrAuto = textBoxNumarAuto.Text.ToString();
            string serieSasiu = textBoxSerieSasiu.Text.ToString();
            string codSasiu = textBoxCodSasiu.Text.ToString();
            string denumireSasiu = textBoxDenumireSasiu.Text.ToString();
            int id = Int32.Parse(textBoxIdClient.Text.ToString());
            //Automobile.Add(nrAuto, serieSasiu, codSasiu, denumireSasiu, id);
            
            Auto a = new Auto();
            Client c = CarServiceAPI.GetClientById(id);
            Sasiu s = new Sasiu();
            a.NumarAuto = nrAuto;
            a.SerieSasiu = serieSasiu;
            s.CodSasiu = codSasiu;
            s.Denumire = denumireSasiu;
            try
            {
                CarServiceAPI.AddAuto(a, c, s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void buttonAutoUpdate_Click(object sender, EventArgs e)
        {
            /*
            string nrAuto = textBoxNumarAuto.Text.ToString();
            string serieSasiu = textBoxSerieSasiu.Text.ToString();
            string codSasiu = textBoxCodSasiu.Text.ToString();
            string denumireSasiu = textBoxDenumireSasiu.Text.ToString();
            int idClient = Int32.Parse(textBoxIdClient.Text.ToString());
            int id = Int32.Parse(textBoxAutoId.Text.ToString());
            Automobile.Update(id, nrAuto, serieSasiu, codSasiu, denumireSasiu, idClient);
            */
        }

        private void buttonAutoDelete_Click(object sender, EventArgs e)
        {
            //Automobile.Delete(Int32.Parse(textBoxAutoId.Text.ToString()));
            int id = Int32.Parse(textBoxAutoId.Text.ToString());
            Auto auto = CarServiceAPI.GetAutoById(id);

            CarServiceAPI.DeleteAuto(auto);
        }
    }
}
