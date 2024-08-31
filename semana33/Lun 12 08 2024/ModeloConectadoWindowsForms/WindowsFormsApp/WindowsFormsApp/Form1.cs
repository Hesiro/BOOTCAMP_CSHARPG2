using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString = @"Data Source=DESKTOP-8HV8MKS;" +
            "Initial Catalog=ModeloConectadoWindowsForms;" +
            "Integrated Security=true"; 
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataFlight();
        }

        private void RefreshDataFlight()
        {
            connection =
                new SqlConnection("Data Source=DESKTOP-8HV8MKS; " +
                "Initial Catalog=ModeloConectadoWindowsForms;" +
                "Integrated Security=true");
            command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "select * from Flight";
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridViewFlight.DataSource = dt;

                comboBoxFlightGeneral.DataSource = dt;
                comboBoxFlightGeneral.DisplayMember = "FlightNumber";
                comboBoxFlightGeneral.ValueMember = "Id";

                comboBoxAirplaneType.DataSource = dt;
                comboBoxAirplaneType.DisplayMember = "AirPlaneType";
                comboBoxAirplaneType.ValueMember = "Id";

                comboBoxFlightNumber.DataSource = dt;
                comboBoxFlightNumber.DisplayMember = "FlightNumber";
                comboBoxFlightNumber.ValueMember = "Id";

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }

        private void buttonAddFlight_Click(object sender, EventArgs e)
        {
            string airline = textBoxFlightNumber.Text;
            string flightNumber = textBoxFlightNumber.Text;
            string destination = textBoxDestination.Text;
            string airPlanetype = comboBoxAirplaneType.SelectedItem.ToString();

            DataRowView selectRow = (DataRowView)comboBoxAirplaneType.SelectedItem;

            if (selectRow != null) {
                airPlanetype = selectRow["AirPlaneType"].ToString();
            }

            if(string.IsNullOrEmpty(airline) ||
                string.IsNullOrEmpty(flightNumber) ||
                string.IsNullOrEmpty(destination) ||
                string.IsNullOrEmpty(airPlanetype))
            {
                MessageBox.Show("Es necesario completar todos los datos");
                return;
            }

            connection.ConnectionString = connectionString;
            command = new SqlCommand(@"insert into Flight(Airline, FlightNumber, Destination, AirPlaneType) " +
                "values(@Airline, @FlightNumber, @Destination, @AirPlanetype)",connection);
            command.Parameters.AddWithValue("@Airline", airline);
            command.Parameters.AddWithValue("@FlightNumber", flightNumber);
            command.Parameters.AddWithValue("@Destination", destination);
            command.Parameters.AddWithValue("@AirPlanetype", airPlanetype);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally 
            { 
                command.Dispose(); 
                connection.Close();
                RefreshDataFlight();
            }
        }

        private void comboBoxFlightGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectRow = (DataRowView)comboBoxFlightGeneral.SelectedItem;

            if (selectRow != null)
            {                
                int selectedFlightById = Convert.ToInt32(selectRow["Id"]);
                if (selectedFlightById > 0) 
                {                    
                    LoadFlightDetails(selectedFlightById);
                }
            }
        }

        private void LoadFlightDetails(int id)
        {            
            command = connection.CreateCommand();
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                }
                
                string query = "select * from Flight where Id = @FlightId";
                command.CommandText = query;
                command.Parameters.AddWithValue ("@FlightId", id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) { 
                    textBoxAirline.Text = reader["Airline"].ToString();
                    textBoxFlightNumber.Text = reader["FlightNumber"].ToString();
                    textBoxDestination.Text = reader["Destination"].ToString();
                    //comboBoxAirplaneType.SelectedValue = reader["AirPlaneType"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally 
            { 
                command.Dispose();
                connection.Close();
            }
        
        }

        private void buttonUpdateFlight_Click(object sender, EventArgs e)
        {
            if(comboBoxFlightGeneral.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un vuelo para actualizar");
                return;
            }
            int id = Convert.ToInt32(comboBoxFlightGeneral.SelectedValue);
            string airline = textBoxAirline.Text;
            string flightNumber = textBoxFlightNumber.Text;
            string destination = textBoxDestination.Text;
            string airPlanetype = comboBoxAirplaneType.SelectedItem.ToString();

            //DataRowView selectRow = (DataRowView)comboBoxAirplaneType.SelectedItem;

            //if (selectRow != null)
            //{
            //    airPlanetype = selectRow["AirPlaneType"].ToString();
            //}

            if (string.IsNullOrEmpty(airline) ||
                string.IsNullOrEmpty(flightNumber) ||
                string.IsNullOrEmpty(destination) ||
                string.IsNullOrEmpty(airPlanetype))
            {
                MessageBox.Show("Es necesario llenar todos los campos");
                return;
            }

            connection.ConnectionString = connectionString;
            command = new SqlCommand(@"update Flight set Airline = @Airline, " +
                "FlightNumber = @FlightNumber, " +
                "Destination = @Destination, " +
                "AirPlaneType = @AirPlanetype " +
                "where Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Airline", airline);
            command.Parameters.AddWithValue("@FlightNumber", flightNumber);
            command.Parameters.AddWithValue("@Destination", destination);
            command.Parameters.AddWithValue("@AirPlanetype", airPlanetype);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally 
            { 
                command.Dispose();
                connection.Close();
                RefreshDataFlight();
            }
        }

        private void buttonDeleteFlight_Click(object sender, EventArgs e)
        {
            if(comboBoxFlightGeneral.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un vuelo para eliminar");
                return;
            }
            int id = Convert.ToInt32(comboBoxFlightGeneral.SelectedValue);
            connection.ConnectionString = connectionString;
            command = new SqlCommand(@"delete Flight " +                
                "where Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally 
            {
                command.Dispose();
                connection.Close();
                RefreshDataFlight();
            }
        }
    }
}
