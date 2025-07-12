namespace WelcomeWebpage.Models
{
    public class OpenWeatherResponse
    {
        public MainInfo? Main { get; set; }
        public List<WeatherDetails> Weather { get; set; }
        public string? Name { get; set; }
    }

    public class MainInfo
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }

        public int Humidity { get; set; }
    }

    public class WeatherDetails
    {
        
        public string? Icon { get; set; }
    }

   

}
