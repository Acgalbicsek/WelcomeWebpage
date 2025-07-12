namespace WelcomeWebpage.Models
{
    public class Weather
    {
        public string? City { get; set; }
        public double Temperature { get; set; }
        public double FeelsLike {  get; set; }
        public int Humidity {  get; set; }
        public string? IconUrl { get; set; }

    }
}
