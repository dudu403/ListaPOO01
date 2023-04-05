using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO07.ConsoleApp
{
    internal class Comissao
    {
        public double salarioBase;
        public double taxaComissao;
        public double totalVendas;
        public double comissao;
        public double salarioTotal;

        public decimal CalcularComissao()
        {
            return (decimal)(comissao = (totalVendas * (taxaComissao / 100.0)));
        }

        public decimal CalcularSalarioTotal()
        {
            return (decimal) (salarioTotal = (salarioBase + comissao));
        }
    }
}
