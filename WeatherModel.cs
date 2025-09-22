namespace WeatherAppConsole
{
    // Model class to represent weather data
    public class WeatherModel
    {
        public string City { get; set; }        // City name
        public string Description { get; set; } // Weather description (e.g., "clear sky")
        public string Temperature { get; set; } // Temperature in °C
        public string Humidity { get; set; }    // Humidity percentage
        public string Wind { get; set; }        // Wind speed

        // Override ToString() so it prints nicely formatted weather data
        public override string ToString()
        {
            return $"\nCity: {City}\n" +
                   $"Temperature: {Temperature}\n" +
                   $"Description: {Description}\n" +
                   $"Humidity: {Humidity}\n" +
                   $"Wind: {Wind}\n";
        }
    }
}
