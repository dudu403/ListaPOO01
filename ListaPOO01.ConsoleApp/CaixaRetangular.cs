using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO01.ConsoleApp
{
    internal class CaixaRetangular
    {
        public int altura;
        public int comprimento;
        public int largura;

        public decimal CalcularVolume()
        {
            return altura * comprimento * largura;
        }
    }
}
