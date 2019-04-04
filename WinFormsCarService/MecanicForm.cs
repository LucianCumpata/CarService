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
    public partial class MecanicForm : Form
    {
        public MecanicForm()
        {
            InitializeComponent();
            ShowMecanicsList();
        }

        private void ShowMecanicsList()
        {
            
            IEnumerable<Mecanic> mecanics = CarServiceAPI.ListAllMecanics();
            listViewMecanics.Items.Clear();
            foreach (var mecanic in mecanics)
            {
                ListViewItem item = new ListViewItem();
                item.Text = mecanic.Id.ToString();
                item.SubItems.Add(mecanic.Nume);
                item.SubItems.Add(mecanic.Prenume);
                listViewMecanics.Items.Add(item);
            }
            CarServiceAPI.DisposeModelCarServiceContext();
        }

        private void MecanicForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddMecanic_Click(object sender, EventArgs e)
        {
           

        }

        private void textBoxNumeMecanic_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMecanicUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxNumeMecanic_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxPrenumeMecanic_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMecanicId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddMecanic_Click_1(object sender, EventArgs e)
        {
            string nume = textBoxNumeMecanic.Text.ToString();
            string prenume = textBoxPrenumeMecanic.Text.ToString();
            Mecanic m = new Mecanic
            {
                Nume = nume,
                Prenume = prenume
            };

            if (nume.Length>2 && prenume.Length>2)
            {
                try
                {
                    CarServiceAPI.AddMecanic(m);
                    MessageBox.Show("Mecanicul " + m.Nume + " " + m.Prenume + " a fost adaugat cu succes!");
                    
                    ShowMecanicsList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
                finally
                {
                    textBoxNumeMecanic.Clear();
                    textBoxPrenumeMecanic.Clear();
                }
            }
            else
            {
                MessageBox.Show("Completati Numele si prenumele mecanicului!");
            }
            /*
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
            */
        }

        private void listViewMecanics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonMecanicDelete_Click(object sender, EventArgs e)
        {
            if (listViewMecanics.SelectedItems.Count == 0)
            {
                return;
            }

            try
            {
                ListViewItem viewItem = listViewMecanics.SelectedItems[0];
                var mecanic = CarServiceAPI.GetMecanicById(int.Parse(viewItem.Text.ToString()));
                CarServiceAPI.DeleteMecanic(mecanic);
                
                ShowMecanicsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
