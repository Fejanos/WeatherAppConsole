using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherAppConsole
{
    // Service class that handles API requests to OpenWeatherMap
    public class WeatherService
    {
        // Replace with your own OpenWeatherMap API key
        private readonly string apiKey = "YOUR_API_KEY_HERE"; 
        private readonly HttpClient client;

        public WeatherService()
        {
            // Initialize HttpClient
            client = new HttpClient();
        }

        // Fetch weather data for a given city asynchronously
        public async Task<WeatherModel> GetWeatherAsync(string city)
        {
            try
            {
                // Build the request URL with city name, metric units, API key and English language
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}&lang=en";

                // Send HTTP GET request
                var response = await client.GetStringAsync(url);

                // Parse JSON response
                JObject data = JObject.Parse(response);

                // Map JSON fields to WeatherInfo object
                return new WeatherModel
                {
                    City = data["name"]?.ToString(),
                    Temperature = Math.Round(double.Parse(data["main"]["temp"].ToString())) + "°C",
                    Description = data["weather"][0]["description"].ToString(),
                    Humidity = data["main"]["humidity"] + "%",
                    Wind = data["wind"]["speed"] + " m/s"
                };
            }
            catch (Exception ex)
            {
                // Display error if API request fails
                Console.WriteLine($"Failed to fetch weather: {ex.Message}");
                return null;
            }
        }
    }
}
