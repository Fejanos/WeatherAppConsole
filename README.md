# 🌤️ WeatherApp Console (C#)

A simple **console weather application** built in **C#**.  
It uses the [OpenWeatherMap API](https://openweathermap.org/api) to fetch live weather data and displays it in the terminal.

---

## ✨ Features
- 🔍 Search weather by **city name**
- 🌡️ Shows **temperature, humidity, wind speed, and weather description**
- 📦 Clean separation of concerns:
  - `Program.cs` → main entry point
  - `WeatherModel.cs` → model class to store weather data
  - `WeatherServices.cs` → service class for API requests
- 🛠️ Error handling for invalid inputs or failed API calls

---

## 📸 Example Output
```bash
Welcome to WeatherApp Console!

Enter city name (or 'exit' to quit): London

City: London
Temperature: 15°C
Description: broken clouds
Humidity: 49%
Wind: 3.6 m/s
```

---


---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK 6.0+](https://dotnet.microsoft.com/en-us/download)
- [OpenWeatherMap API key](https://home.openweathermap.org/api_keys)

### Installation
1. Clone this repository:
   ```sh
   git clone https://github.com/YOUR_USERNAME/WeatherAppConsole.git
   cd WeatherAppConsole
   ```
2. Add your own API key in WeatherServices.cs:
    ```sh
    private readonly string apiKey = "YOUR_API_KEY_HERE";
    ```
3. Run the project:
    ```bash
    dotnet run
    ```

---

### API Key Security

Do not commit your personal API key to GitHub.
In a real-world project, you would store it in:
- an appsettings.json file (ignored by Git),
- or environment variables.
For this exercise, keeping it in the source file is fine for local testing.

---

## Built With
- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [.NET](https://dotnet.microsoft.com/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [OpenWeatherMap API](https://openweathermap.org/api)
- [Newtonsoft.Json](https://www.newtonsoft.com/json)