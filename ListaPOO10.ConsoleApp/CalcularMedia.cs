using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO10.ConsoleApp
{
    internal class CalcularMedia
    {
        public double nota1;
        public double peso1;
        public double nota2;
        public double peso2;
        public double media;

       public decimal CalcularMediaNotas()
        {
            return (decimal)(media = (nota1 * peso1 + nota2 * peso2) / (peso1 * peso2));
        } 
    }
}
