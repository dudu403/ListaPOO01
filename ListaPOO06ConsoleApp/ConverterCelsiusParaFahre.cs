using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO06ConsoleApp
{
    internal class ConverterCelsiusParaFahre
    {
        public int fahrenheit;
        public int celsius;

        public decimal Converter()
        {
            return fahrenheit = (int)((celsius * 9.0 / 5.0) + 32.0);
        }
    }
}
