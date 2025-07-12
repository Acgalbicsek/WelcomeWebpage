using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WelcomeWebpage.Models;


namespace WelcomeWebpage.Controllers
{
    public class WeatherController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(string city = "Fairbanks")
        {
            var weather = await GetWeatherAsync(city);
            return View(weather);
        }

        private async Task<Weather> GetWeatherAsync(string city)
        {
            var client = _httpClientFactory.CreateClient();
            var apikey = "fc406fd5d170148b4195ae74e321da58";
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={apikey}";

            var response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<OpenWeatherResponse>(json);

            

            var weather = new Weather
            {
                City = data.Name,
                Temperature = data.Main.Temp,
                FeelsLike = data.Main.Feels_Like,
                Humidity = data.Main.Humidity,
                IconUrl = $"http://openweathermap.org/img/w/{data.Weather[0].Icon}.png"
            };
            return weather;
        }

         

    }

}

       




