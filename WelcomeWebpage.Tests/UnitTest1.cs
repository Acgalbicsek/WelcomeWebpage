using WelcomeWebpage.Services;
using WelcomeWebpage.Models;
using Xunit;

namespace WelcomeWebpage.Tests
{
    public class UnitTest1 
    {
        [Fact]
        public void ConvertCelsiusToFahrenheit_ReturnsCorrectValue()
        {
            var service = new WeatherServices();
            var result = service.ConvertCelsiusToFahrenheit(0);
            Assert.Equal(32, result);
        }

        [Fact]
        public void GetWeatherData_ReturnsWeatherObject_WithCorrectCity()
        {
            // Arrange
            var service = new WeatherServices();

            // Act
            var result = service.GetWeatherData("Fairbanks");

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Fairbanks", result.City);
            Assert.InRange(result.Temperature, -100, 150); 
        }
    }
}
