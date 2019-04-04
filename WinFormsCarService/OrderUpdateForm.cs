using CarService;
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

namespace WinFormsCarService
{
    public partial class OrderUpdateForm : Form
    {
        public OrderUpdateForm()
        {
            InitializeComponent();
            var order = CarServiceAPI.GetComandaById(GUI_WF.GetSelectedOrderId());
            dateTimePickerOrderFinish.Value = order.DataFinalizare;
            dateTimePickerOrderStart.Value = order.DataProgramare;
            numericUpDownKm.Value = order.KmBord;
            richTextBoxOrderDescription.Text = order.Descriere;
            if (order.StareComanda == "In asteptare")
            {
                radioButtonOrderAwaiting.Checked = true;
            }
            else if (order.StareComanda == "Executata")
            {
                radioButtonOrderExecuted.Checked = true;
            }
            else
            {
                radioButtonOrderRefused.Checked = true;
            }
        }

        private void dateTimePickerOrderStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerOrderFinish_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownKm_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxOrderDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            var comanda = CarServiceAPI.GetComandaById(GUI_WF.GetSelectedOrderId());
            //var client = CarServiceAPI.GetClientById(GUI_WF.GetSelectedClientId());
            //var auto = CarServiceAPI.GetAutoById(GUI_WF.GetSelectedAutoId());

            string description = richTextBoxOrderDescription.Text.ToString();
            decimal kmBord = numericUpDownKm.Value;
            var orderStartDate = new SqlDateTime(dateTimePickerOrderStart.Value);
            var orderFinishDate = new SqlDateTime(dateTimePickerOrderFinish.Value);


            comanda.KmBord = int.Parse(kmBord.ToString());
            comanda.Descriere = description;
            comanda.DataProgramare = orderStartDate.Value;
            comanda.DataFinalizare = orderFinishDate.Value;

            if (radioButtonOrderAwaiting.Checked == true)
            {
                comanda.StareComanda = "In asteptare";
            }
            else if (radioButtonOrderExecuted.Checked == true)
            {
                comanda.StareComanda = "Executata";
            }
            else if (radioButtonOrderRefused.Checked == true)
            {
                comanda.StareComanda = "Refuzata";
            }
            

            try
            {
                CarServiceAPI.UpdateComanda(comanda);
                MessageBox.Show("Comanda a fost modificata cu succes!");
                this.Close();
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

        private void radioButtonOrderAwaiting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOrderExecuted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOrderRefused_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
