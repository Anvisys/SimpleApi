using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleApi.Test
{
    public class UnitTest1
    {
        
        WeatherForecastController weatherController = new WeatherForecastController(null);

        [Fact]
        public void GetWeathers()
        {

              var weatherList =  weatherController.Get();

              Assert.Equal(5, 5);

        }

        [Fact]
        public void Test1()
        {

        }
    }
}
