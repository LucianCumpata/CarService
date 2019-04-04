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
            DisableButtons();
        }

        private void DisableButtons()
        {
            buttonAddCar.Enabled = false;
            buttonAutoDelete.Enabled = false;
            buttonAutoUpdate.Enabled = false;
            buttonNewOrder.Enabled = false;
            buttonClientDelete.Enabled = false;
            buttonOrderDetails.Enabled = false;
            buttonOrderUpdate.Enabled = false;
        }

        private void ShowClientsList()
        {
            IEnumerable<Client> clients = CarServiceAPI.ListAllClients();
            listViewClients.Items.Clear();
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
            ShowClientsList();
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
                DisableButtons();
                listViewCars.Items.Clear();
                listViewOrders.Items.Clear();
                richTextBoxOrderDescription.Clear();
                return;
            }

            buttonAddCar.Enabled = true;
            buttonClientDelete.Enabled = true;

            ListViewItem viewItem = listViewClients.SelectedItems[0];
         
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
            GUI_WF.SetSelectedClientId(client.Id);
            CarServiceAPI.DisposeModelCarServiceContext();
        
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
            if (listViewCars.SelectedItems.Count == 0)
            {
                DisableButtons();
                buttonAddCar.Enabled = true;
                return;
            }

            buttonAutoUpdate.Enabled = true;
            buttonAutoDelete.Enabled = true;
            buttonNewOrder.Enabled = true;

            ListViewItem viewAutoItem = listViewCars.SelectedItems[0];

            //GUI_WF.SetSelectedAutoId(int.Parse(viewCarItem.Text.ToString()));

            var auto = CarServiceAPI.GetAutoById(int.Parse(viewAutoItem.Text.ToString()));

            IEnumerable<Comanda> orders = CarServiceAPI.ListOrdersByAuto(auto);

            listViewOrders.Items.Clear();

            foreach (var order in orders)
            {
                ListViewItem item = new ListViewItem();
                item.Text = order.Id.ToString();
                item.SubItems.Add(order.StareComanda);
                item.SubItems.Add(order.DataSystem.ToString());
                item.SubItems.Add(order.DataProgramare.ToString());
                item.SubItems.Add(order.DataFinalizare.ToString());
                item.SubItems.Add(order.KmBord.ToString());
                listViewOrders.Items.Add(item);
            }
            GUI_WF.SetSelectedAutoId(auto.Id);
            CarServiceAPI.DisposeModelCarServiceContext();

        }

        private void CarServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            var autoForm = new AddCarForm();
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
            var newOrderForm = new NewOrderForm();
            newOrderForm.ShowDialog();
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 0)
            {
                buttonOrderDetails.Enabled = false;
                buttonOrderUpdate.Enabled = false;
                return;
            }
            richTextBoxOrderDescription.Clear();

            buttonOrderDetails.Enabled = true;
            buttonOrderUpdate.Enabled = true;

            ListViewItem viewItem = listViewOrders.SelectedItems[0];
            var order = CarServiceAPI.GetComandaById(int.Parse(viewItem.Text.ToString()));
            GUI_WF.SetSelectedOrderId(order.Id);
            richTextBoxOrderDescription.Text = order.Descriere;

        }

        private void buttonOrderDetails_Click(object sender, EventArgs e)
        {
            var orderDetailsForm = new OrderDetailsForm();
            orderDetailsForm.ShowDialog();
        }

        private void richTextBoxOrderDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClientDelete_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem viewItem = listViewClients.SelectedItems[0];
            var client = CarServiceAPI.GetClientById(int.Parse(viewItem.Text.ToString()));
            CarServiceAPI.DeleteClient(client);
        }

        private void showAllMecanicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mecanicForm = new MecanicForm();
            mecanicForm.ShowDialog();
        }

        private void buttonOrderUpdate_Click(object sender, EventArgs e)
        {
            var orderUpdateForm = new OrderUpdateForm();
            orderUpdateForm.ShowDialog();
        }
    }
}
