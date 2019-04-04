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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }


        private void textBoxNumarAuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSerieSasiu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCodSasiu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDenumireSasiu_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void buttonAddAuto_Click(object sender, EventArgs e)
        {
            string nrAuto = textBoxNumarAuto.Text.ToString();
            string serieSasiu = textBoxSerieSasiu.Text.ToString();
            string codSasiu = textBoxCodSasiu.Text.ToString();
            string denumireSasiu = textBoxDenumireSasiu.Text.ToString();
            string idClient = (GUI_WF.GetSelectedClientId().ToString());


            Auto a = new Auto();
            Client c = CarServiceAPI.GetClientById(int.Parse(idClient));
            Sasiu s = new Sasiu();
            a.NumarAuto = nrAuto;
            a.SerieSasiu = serieSasiu;
            s.CodSasiu = codSasiu;
            s.Denumire = denumireSasiu;
            try
            {
                CarServiceAPI.AddAuto(a, c, s);
                MessageBox.Show("Masina a fost adaugata cu succes");
                textBoxNumarAuto.Clear();
                textBoxSerieSasiu.Clear();
                textBoxCodSasiu.Clear();
                textBoxDenumireSasiu.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
