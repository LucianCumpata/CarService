using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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

        public NewOrderForm()
        {
            InitializeComponent();
        }

        private void buttonAddNewOrder_Click(object sender, EventArgs e)
        {
            var comanda = new Comanda();
            var client = CarServiceAPI.GetClientById(GUI_WF.GetSelectedClientId());
            var auto = CarServiceAPI.GetAutoById(GUI_WF.GetSelectedAutoId());

            string description = richTextBoxOrderDescription.Text.ToString();
            decimal kmBord = numericUpDownKm.Value;
            var orderStartDate = new SqlDateTime(dateTimePickerOrderStart.Value);
            var orderFinishDate = new SqlDateTime(dateTimePickerOrderFinish.Value);


            comanda.KmBord = int.Parse(kmBord.ToString());
            comanda.Descriere = description;
            comanda.DataProgramare = orderStartDate.Value;
            comanda.DataFinalizare = orderFinishDate.Value;

            try
            {
                CarServiceAPI.AddComanda(comanda, client, auto);
                MessageBox.Show("Comanda a fost adaugata cu succes!");
                richTextBoxOrderDescription.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                CarServiceAPI.DisposeModelCarServiceContext();
            }
            
            
        }
    }
}
