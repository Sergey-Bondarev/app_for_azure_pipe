using Microsoft.AspNetCore.Mvc;
using app_for_azure_pipe;
using app_for_azure_pipe.Controllers;

namespace app_for_azure_pipe
{
    public class UnitTest1
    {
        [Fact]
        public void Get_ReturnsOkResult_WithForecastArray()
        {
            // Arrange
            var controller = new WeatherForecastController();

            // Act
            var result = controller.Get();

            // Assert
            var forecasts = Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(result);
            Assert.Equal(5, System.Linq.Enumerable.Count(forecasts));
        }
    }
}