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
        IEnumerable<Client> Clients { get; set; }
        IEnumerable<Mecanic> Mecanics { get; set; }
        IEnumerable<Auto> Autos { get; set; }
        IEnumerable<Comanda> Orders { get; set; }

        public string IdClient { get; set; }
        string Nume { get; set; }
        string Prenume { get; set; }
        string Telefon { get; set; }
        string Email { get; set; }
        string Adresa { get; set; }
        string Localitate { get; set; }
        string Judet { get; set; }

        string IdAuto { get; set; }
        string NumarAuto { get; set; }
        string SerieSasiu { get; set; }
        string CodSasiu { get; set; }
        string DenumireSasiu { get; set; }

        public MainWindow()
        {
            CarServiceClient csc = new CarServiceClient();
            
            InitializeComponent();
            Mecanics = csc.ListAllMecanics();
            MecanicsList.ItemsSource = Mecanics;

            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
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

        private void ClientList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //https://stackoverflow.com/questions/2148978/wpf-toolkit-datagrid-selectionchanged-getting-cell-value

            CarServiceClient csc = new CarServiceClient();
            DataGrid ClientList = sender as DataGrid;
            DataGridRow row = (DataGridRow)ClientList.ItemContainerGenerator.ContainerFromIndex(ClientList.SelectedIndex);
            DataGridCell RowColumn = ClientList.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string CellValue = ((TextBlock)RowColumn.Content).Text;

            //MessageBox.Show(CellValue);

            var client = csc.GetClientById(int.Parse(CellValue));

            Autos = csc.ListAutosByClient(client);

        
            GUI_WPF.SetSelectedClientId(client.Id);
            CarList.ItemsSource = Autos;
        }


        private void BtnViewAllClients_Click(object sender, RoutedEventArgs e)
        {
            CarServiceClient csc = new CarServiceClient();

            Clients = csc.ListAllClients();
  
            ClientList.ItemsSource = Clients;
        }

        private void BtnSearchClient_Click(object sender, RoutedEventArgs e)
        {
            string searchName = TxtBoxSearch.Text.ToString();
            CarServiceClient csc = new CarServiceClient();
            Clients = csc.ListClientsByName(searchName);
            ClientList.ItemsSource = Clients;
        }

        private void BtnNewClient_Click(object sender, RoutedEventArgs e)
        {
            AddNewClient addNewClient = new AddNewClient();
            addNewClient.ShowDialog();
        }

        private void BtnAddCar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrdersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CarList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarServiceClient csc = new CarServiceClient();
            DataGrid CarsList = sender as DataGrid;
            DataGridRow row = (DataGridRow)CarsList.ItemContainerGenerator.ContainerFromIndex(CarsList.SelectedIndex);
            DataGridCell RowColumn = CarsList.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string CellValue = ((TextBlock)RowColumn.Content).Text;

            var auto = csc.GetAutoById(int.Parse(CellValue));

            Orders = csc.ListOrdersByAuto(auto);

            GUI_WPF.SetSelectedAutoId(auto.Id);
            OrdersList.ItemsSource = Orders;
        }
    }
}
