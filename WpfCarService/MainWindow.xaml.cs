using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using CarService;


namespace WpfCarService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IEnumerable<Mecanic> Mecanics { get; set; }
        public MainWindow()
        {
            CarServiceClient carServiceMecanic = new CarServiceClient();
            
            InitializeComponent();
            Mecanics = carServiceMecanic.ListAllMecanics();
            MecanicsList.ItemsSource = Mecanics;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CarServiceClient carServiceClient = new CarServiceClient();
            Client client = new Client();

            string fName = Nume.Text.ToString();
            string lName = Prenume.Text.ToString();
            string addrs = Adress.Text.ToString();
            string loc = Localitate.Text.ToString();
            string county = County.Text.ToString();
            string phoneNr = Phone.Text.ToString();
            string email = Email.Text.ToString();

            client.Nume = fName;
            client.Prenume = lName;
            client.Adresa = addrs;
            client.Localitate = loc;
            client.Judet = county;
            client.Telefon = phoneNr;
            client.Email = email;

            try
            {
                carServiceClient.AddClient(client);
                MessageBox.Show("Clientul " + client.Nume + " " + client.Prenume + " a fost adaugat cu succes!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                this.Close();
            }
        }

        

        private void BtnViewAllMecanics_Click(object sender, RoutedEventArgs e)
        {
            CarServiceClient carServiceMecanic = new CarServiceClient();

            Mecanics = carServiceMecanic.ListAllMecanics();
            MecanicsList.Items.Clear();

            MecanicsList.ItemsSource = Mecanics;
         
            //DisposeModelCarServiceContext();
        }

        private void MecanicsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAddNewMecanic_Click(object sender, RoutedEventArgs e)
        {
            CarServiceClient carSeMecanic = new CarServiceClient();
            Mecanic m = new Mecanic();

            string fName = TxtBxNumeMecanic.Text.ToString();
            string lName = TxtBxPrenumeMecanic.Text.ToString();

            m.Nume = fName;
            m.Prenume = lName;

            if (fName.Length > 2 && lName.Length > 2)
            {
                try
                {
                    carSeMecanic.AddMecanic(m);
                    MessageBox.Show("Mecanicul " + m.Nume + " " + m.Prenume + " a fost adaugat cu succes!");

                    //ShowMecanicsList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
                finally
                {
                    TxtBxNumeMecanic.Clear();
                    TxtBxPrenumeMecanic.Clear();
                }
            }
            else
            {
                MessageBox.Show("Completati Numele si prenumele mecanicului!");
            }
        }
    }
}
