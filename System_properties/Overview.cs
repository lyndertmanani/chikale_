using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using Green_house_chikale.Authn;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace Green_house_chikale.System_properties
{
    public partial class Overview : UserControl
    {
        private readonly string apiKey = "fdd2b9289d7b31b399f475c08ffa56aa";
        private readonly HttpClient httpClient = new HttpClient();

        public Overview()
        {
            InitializeComponent();
            AuthnUser.Text = Signin.Sessions;

            // Load weather data when the form loads
            LoadWeatherData();
        }
        Database db = new Database();
        private async void LoadWeatherData()
        {

            db.OpenConnection();
            // Create a MySqlCommand to execute the query
            string query = "SELECT location FROM settings";
            MySqlCommand command = new MySqlCommand(query, db.GetConnection);
            // Execute the query and get the result
            string location = command.ExecuteScalar()?.ToString();
            // Close the database connection
            db.CloseConnection();
            // Assign the retrieved location value to the text property of the label
      
            try
            {
                // Get current weather by city name
                string city = location; // Replace "YOUR_CITY_NAME" with the desired city name
                string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(jsonResponse);

                    // Update UI with weather data
                    celciusLabel.Text = Math.Round(Convert.ToDecimal(data.main.temp)) + "°C"; // Convert temperature to decimal
                    Humidity.Text = Math.Round(Convert.ToDecimal(data.main.humidity)) + "%"; // Convert humidity to decimal
                    Winds.Text = Math.Round(Convert.ToDecimal(data.wind.speed)) + "km/h"; // Convert wind speed to decimal
                    pressureLabel.Text = Math.Round(Convert.ToDecimal(data.main.pressure)) + "mb"; // Convert pressure to decimal

                    // Display recommendation based on weather conditions
                    if (Convert.ToDecimal(data.main.temp) > 25 && Convert.ToDecimal(data.main.humidity) > 50)
                    {
                        recommendationLabel.Text = "It's a great time to water your plants!";
                    }
                    else
                    {
                        recommendationLabel.Text = "Oops🤔! check weather conditions before watering your plants🌱.";
                    }
                }
                else
                {
                    MessageBox.Show("Error fetching weather data. Please try again later.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


private void PopulateChart()
{
    try
    {
        // Clear existing data in chart
        chart1.Series.Clear();

        // Create series for income and output
        Series incomeSeries = new Series("Income");
        Series outputSeries = new Series("Output");

        // Set chart type to column
        incomeSeries.ChartType = SeriesChartType.Column;
        outputSeries.ChartType = SeriesChartType.Column;

        // Add series to chart
        chart1.Series.Add(incomeSeries);
        chart1.Series.Add(outputSeries);

        // Retrieve data from MySQL database
        using (MySqlConnection connection = new MySqlConnection(db.GetConnection.ConnectionString))
        {
            string query = "SELECT MONTH(Date) AS Month, SUM(CASE WHEN Activites = 'income' THEN Amount ELSE 0 END) AS Income, " +
                           "SUM(CASE WHEN Activites = 'output' THEN Amount ELSE 0 END) AS Output " +
                           "FROM expense " +
                           "GROUP BY MONTH(Date)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Populate chart with retrieved data
                    while (reader.Read())
                    {
                        int monthValue = reader.GetInt32("Month");
                        if (monthValue >= 1 && monthValue <= 12) // Check if month value is valid
                        {
                            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(monthValue);
                            decimal income = reader.GetDecimal("Income");
                            decimal output = reader.GetDecimal("Output");

                            // Add data points to series
                            incomeSeries.Points.AddXY(monthName, income);
                            outputSeries.Points.AddXY(monthName, output);
                        }
                    }
                }
            }
        }

        // Set titles for X and Y axes
        chart1.ChartAreas[0].AxisX.Title = "Month";
        chart1.ChartAreas[0].AxisY.Title = "Amount";
    }
    catch (MySqlException ex)
    {
        MessageBox.Show("Error connecting to database: " + ex.Message);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}

    

        private void Overview_Load(object sender, EventArgs e)
        {
            PopulateChart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
