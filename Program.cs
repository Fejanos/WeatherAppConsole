using System;
using System.Threading.Tasks;

namespace WeatherAppConsole
{
    class Program
    {
        // Entry point of the console application
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to WeatherApp Console!\n");

            var service = new WeatherService();

            while (true)
            {
                // Ask the user for a city name
                Console.Write("Enter city name (or 'exit' to quit): ");
                string city = Console.ReadLine().Trim();

                // Exit condition
                if (string.Equals(city, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                // Handle empty input
                if (string.IsNullOrWhiteSpace(city))
                {
                    Console.WriteLine("Please enter a valid city.");
                    continue;
                }

                // Call the WeatherService to fetch weather information
                var weather = await service.GetWeatherAsync(city);

                // Display the result if successful
                if (weather != null)
                {
                    Console.WriteLine(weather);
                }
                else
                {
                    Console.WriteLine("Could not fetch weather. Try again.");
                }
            }

            Console.WriteLine("\nGoodbye!");
        }
    }
}
