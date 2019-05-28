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
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
