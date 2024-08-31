using System;
using System.Collections.Generic;
using System.Data;
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

namespace ModeloDesconectadoWpfApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> listAircrafts = new List<string>();
        DataSet1 dataSet1 = new DataSet1();

        /*Flight*/
        DataSet1TableAdapters.FlightTableAdapter flightTableAdapter = 
            new DataSet1TableAdapters.FlightTableAdapter();
        DataSet1.FlightDataTable flightDataTable = 
            new DataSet1.FlightDataTable();

        /*User*/
        DataSet1TableAdapters.UsersTableAdapter usersTableAdapter =
            new DataSet1TableAdapters.UsersTableAdapter();
        DataSet1.UsersDataTable userDataTable = 
            new DataSet1.UsersDataTable();

        public MainWindow()
        {
            InitializeComponent();
            listAircrafts.Clear();
            listAircrafts.Add("Boeing 737");
            listAircrafts.Add("Boeing 747");
            listAircrafts.Add("Boeing 757");
            listAircrafts.Add("Boeing 767");
            listAircrafts.Add("Boeing 777");
            listAircrafts.Add("Boeing 120");

            comboBoxAircraft.ItemsSource = listAircrafts;

            RefreshDataGridFhlight();
        }

        private void RefreshDataGridFhlight()
        {
            flightTableAdapter.Fill(dataSet1.Flight);
            flightTableAdapter.Fill(flightDataTable);

            dataGridFlights.ItemsSource = flightDataTable;

            comboBoxFlights.ItemsSource = flightDataTable;
            comboBoxFlights.DisplayMemberPath = "FlightNumber";
            comboBoxFlights.SelectedValuePath = "Id";

            comboBoxNextFlight.ItemsSource = flightDataTable;
            comboBoxNextFlight.DisplayMemberPath = "FlightNumber";
            comboBoxNextFlight.SelectedValuePath = "Id";
        }

        private void comboBoxFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
