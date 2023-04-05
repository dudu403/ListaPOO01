using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO05ConsoleApp
{
    internal class Esfera
    {
        public double raio;
        public double volume;

        public decimal Calcular()
        {
            return (decimal) (volume = (4/3) * Math.PI * Math.Pow(raio, 3));
        }
    }
}
