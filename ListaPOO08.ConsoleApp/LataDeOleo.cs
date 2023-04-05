using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO08.ConsoleApp
{
    internal class LataDeOleo
    {
        public double raio;
        public double volume;
        public double altura;

        public decimal Calcular()
        {
            return (decimal) (volume = Math.PI * Math.Pow(raio, 2) * altura);
            
        }
    }
}
