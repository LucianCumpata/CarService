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
        private string _selectedClientId;
        private string _selectedAutoId;

        public void SetSelectedClientId(string id)
        {
            _selectedClientId = id;
        }

        public string GetSelectedClientId()
        {
            return _selectedClientId;
        }

        public void SetSelectedAutoId(string id)
        {
            _selectedAutoId = id;
        }

        public string GetSelectedAutoId()
        {
            return _selectedAutoId;
        }

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
            string searchName = textBoxSearchClient.Text.ToString();
            listViewClients.Items.Clear();
            IEnumerable<Client> clients = CarServiceAPI.ListClientsByName(searchName);
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

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 0)
            {
                return;
            }
          
            ListViewItem viewItem = listViewClients.SelectedItems[0];
            //MessageBox.Show(viewItem.Text.ToString());
            var client = CarServiceAPI.GetClientById(int.Parse(viewItem.Text.ToString()));
            
            IEnumerable<Auto> autos = CarServiceAPI.ListAutosByClient(client);
            
            listViewCars.Items.Clear();
            foreach (var auto in autos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = auto.Id.ToString();
                item.SubItems.Add(auto.NumarAuto);
                listViewCars.Items.Add(item);
            }
            SetSelectedClientId(client.Id.ToString());
            CarServiceAPI.DisposeModelCarServiceContext();
            //MessageBox.Show()
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
            var autoForm = new AddCarForm(GetSelectedClientId());
            autoForm.ShowDialog();
        }

        private void textBoxSearchClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAutoDelete_Click(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem viewItem = listViewCars.SelectedItems[0];
            var auto = CarServiceAPI.GetAutoById(int.Parse(viewItem.Text.ToString()));
            CarServiceAPI.DeleteAuto(auto);
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            ListViewItem viewClientItem = listViewClients.SelectedItems[0];
            ListViewItem viewCarItem = listViewCars.SelectedItems[0];

            SetSelectedAutoId(viewCarItem.Text.ToString());
            SetSelectedClientId(viewClientItem.Text.ToString());

            var newOrderForm = new NewOrderForm(GetSelectedAutoId(),GetSelectedClientId());
            newOrderForm.ShowDialog();

        }
    }
}
