using WelcomeWebpage.Models;
using WelcomeWebpage.Services;


namespace WelcomeWebpage.Services
{
    public class WeatherServices
    {
        public double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public Weather GetWeatherData(string city)
        {
            return new Weather
            {
                City = city,
                Temperature = 57,
                FeelsLike = 55,
                Humidity = 72,
                IconUrl = "https://example.com/icon.png"
            };
    

        }
    }
}
