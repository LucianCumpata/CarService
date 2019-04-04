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
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
            ShowOrderDetails();
        }

        private void ShowOrderDetails()
        {
            var comanda = CarServiceAPI.GetComandaById(GUI_WF.GetSelectedOrderId());
            IEnumerable<DetaliuComanda> detaliuComenzi = CarServiceAPI.ListDetaliuComandaByComanda(comanda);
            listViewOrderDetails.Items.Clear();

            foreach (var detaliuComanda in detaliuComenzi)
            {
                ListViewItem item = new ListViewItem();
                item.Text = detaliuComanda.Id.ToString();
                item.SubItems.Add(detaliuComanda.Operatie.Denumire);
                item.SubItems.Add(detaliuComanda.Mecanic.Nume + " " + detaliuComanda.Mecanic.Prenume);
                item.SubItems.Add(detaliuComanda.Operatie.TimpExecutie.ToString());
                item.SubItems.Add(detaliuComanda.Material.Denumire.ToString());

                item.SubItems.Add(detaliuComanda.Material.Pret.ToString());
                item.SubItems.Add(detaliuComanda.Material.Cantitate.ToString());
                item.SubItems.Add(detaliuComanda.Material.DataAprovizionare.ToString());
                listViewOrderDetails.Items.Add(item);
            }
            CarServiceAPI.DisposeModelCarServiceContext();
        }

        private void buttonAddOrderOperation_Click(object sender, EventArgs e)
        {
            var newOrderDetailsForm = new NewOrderDetailsForm();
            newOrderDetailsForm.ShowDialog();

        }

        private void listViewOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrderDetails.SelectedItems.Count == 0)
            { 
                return;
            }

            ListViewItem viewItem = listViewOrderDetails.SelectedItems[0];
            CarServiceAPI.DisposeModelCarServiceContext();


        }

        private void buttonOrderDetailsRefresh_Click(object sender, EventArgs e)
        {
            ShowOrderDetails();
        }
    }
}
