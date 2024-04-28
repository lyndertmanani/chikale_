using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Green_house_chikale.Client_modules
{
    internal class Weathers
    {
        private readonly string apiKey = "fdd2b9289d7b31b399f475c08ffa56aa";
        private string city = "";

        public async Task GetWeatherByLocation(Label celciusLabel, Label humidityLabel, Label windspeedLabel, Label pressureLabel, Label recommendationLabel)
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync("http://ip-api.com/json");
                var content = await response.Content.ReadAsStringAsync();
                dynamic locationData = JsonConvert.DeserializeObject(content);

                await GetWeather(locationData.city, celciusLabel, humidityLabel, windspeedLabel, pressureLabel, recommendationLabel);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching location data: " + ex.Message);
            }
        }

        public async Task GetWeather(string city, Label celciusLabel, Label Humidity, Label Winds , Label pressureLabel, Label recommendationLabel)
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric");
                var content = await response.Content.ReadAsStringAsync();
                dynamic weatherData = JsonConvert.DeserializeObject(content);

                celciusLabel.Text = Math.Round((double)weatherData.main.temp) + "°c";
                Humidity.Text = Math.Round((double)weatherData.main.humidity) + "%";
                Winds.Text = Math.Round((double)weatherData.wind.speed) + "km/h";
                pressureLabel.Text = Math.Round((double)weatherData.main.pressure) + "mb";

                if ((double)weatherData.main.temp > 25 && (double)weatherData.main.humidity > 50)
                {
                    recommendationLabel.Text = "It's a great time to water your plants!";
                }
                else
                {
                    recommendationLabel.Text = "Check weather conditions before watering your plants.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching weather data: " + ex.Message);
            }
        }
    }
}
