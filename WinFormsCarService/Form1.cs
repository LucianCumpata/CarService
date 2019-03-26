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

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxNumarAuto_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void showAllClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<Client> clients = CarServiceAPI.ListAllClients();
         
            foreach (var client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.Id.ToString();
                item.SubItems.Add(client.Nume);
                item.SubItems.Add(client.Prenume);
                item.SubItems.Add(client.Telefon);
                listViewClients.Items.Add(item);
            }   
            CarServiceAPI.DisposeModelCarServiceContext();
            
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {

        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            ListViewItem item = new ListViewItem();
            item.Text = auto.Id.ToString();
            item.SubItems.Add(client.Nume);
            */
        }

        private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newClientForm = new NewClientForm();        
            newClientForm.ShowDialog();
        }

        private void newMecanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mecanicForm = new MecanicForm();
            mecanicForm.ShowDialog();
        }

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            var autoForm = new AddCarForm();
            autoForm.ShowDialog();
        }
    }
}
