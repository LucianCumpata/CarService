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
    public partial class NewOrderForm : Form
    {
        private string _selectedClientId;
        private string _selectedAutoId;

        public NewOrderForm(string clientId, string autoId)
        {
            InitializeComponent();
            _selectedAutoId = autoId;
            _selectedClientId = clientId;
        }

        private void buttonAddNewOrder_Click(object sender, EventArgs e)
        {
            var comanda = new Comanda();
            var client = CarServiceAPI.GetClientById(int.Parse(_selectedClientId));
            var auto = CarServiceAPI.GetAutoById(int.Parse(_selectedAutoId));

            string description = richTextBoxOrderDescription.Text.ToString();
            decimal kmBord = numericUpDownKm.Value;
            //var orderStartDate = dateTimePickerOrderStart.Value.ToString("dd-MM-yyyy");
            var orderStartDate = dateTimePickerOrderStart.Value;
            var orderFinishDate = dateTimePickerOrderFinish.Value;

            comanda.KmBord = int.Parse(kmBord.ToString());
            comanda.Descriere = description;
            comanda.DataProgramare = orderStartDate;
            comanda.DataFinalizare = orderFinishDate;

            CarServiceAPI.AddComanda(comanda, client, auto);

        }
    }
}
