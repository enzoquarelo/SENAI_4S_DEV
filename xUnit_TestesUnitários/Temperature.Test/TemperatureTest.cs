using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature.Test
{
    public class TemperatureTest
    {
        [Fact]
        public void ConverterCelsiusParaFahrenheit_ConvertsZeroDegreesCorrectly()
        {
            double celsius = 0;
            double expectedFahrenheit = 32;

            double actualFahrenheit = Temperature.ConverterCelsiusParaFahrenheit(celsius);

            Assert.Equal(expectedFahrenheit, actualFahrenheit);
        }
    }
}
