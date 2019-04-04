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
    public partial class NewOrderDetailsForm : Form
    {
        public NewOrderDetailsForm()
        {
            InitializeComponent();

            IEnumerable<Mecanic> mecanics = CarServiceAPI.ListAllMecanics();
            listViewMecanics.Items.Clear();

            foreach (var _mecanic in mecanics)
            {
                ListViewItem item = new ListViewItem();
                item.Text = _mecanic.Id.ToString();
                item.SubItems.Add(_mecanic.Nume);
                item.SubItems.Add(_mecanic.Prenume);
                listViewMecanics.Items.Add(item);
            }


        }

        private void listViewMecanics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMecanics.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem viewItem = listViewMecanics.SelectedItems[0];

            var mecanic = CarServiceAPI.GetMecanicById(int.Parse(viewItem.Text.ToString()));
            GUI_WF.SetSelectedMecanicId(mecanic.Id);
        }

        private Material AddMaterial()
        {
            string materialDesc = textBoxMaterialDescription.Text.ToString();
            decimal materialQuantity = numericUpDownMaterialQuantity.Value;
            decimal materialPrice = numericUpDownMaterialPrice.Value;
            var materialArrival = new SqlDateTime(dateTimePickerMaterialArrival.Value);

            var material = new Material()
            {
                Denumire = materialDesc,
                Cantitate = materialQuantity,
                Pret = materialPrice,
                DataAprovizionare = materialArrival.Value
            };

            try
            {
                CarServiceAPI.AddMaterial(material);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return material;

        }

        private Operatie AddOperatie()
        {

            string operationName = textBoxOperationName.Text.ToString();
            decimal executionTime = numericUpDownExecutionTime.Value;

            var operatie = new Operatie()
            {
                Denumire = operationName,
                TimpExecutie = executionTime
            };

            try
            {
                CarServiceAPI.AddOperatie(operatie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return operatie;

        }

        private void buttonAddNewOrderDetails_Click(object sender, EventArgs e)
        {
            var comanda = CarServiceAPI.GetComandaById(GUI_WF.GetSelectedOrderId());
            var mecanic = CarServiceAPI.GetMecanicById(GUI_WF.GetSelectedMecanicId());
            var material = AddMaterial();
            var operatie = AddOperatie();
            var detaliu = new DetaliuComanda();

            try
            {
                CarServiceAPI.AddDetaliuComanda(detaliu, comanda, material, operatie, mecanic);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private void textBoxMaterialDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownMaterialQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownMaterialPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerMaterialArrival_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOperationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownExecutionTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
