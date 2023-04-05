namespace ListaPOO07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comissao comissaoFuncionario = new Comissao();

            comissaoFuncionario.salarioBase = 2000.0;
            comissaoFuncionario.totalVendas = 5000.0;
            comissaoFuncionario.taxaComissao = 5.0;

            Console.WriteLine("Comissão: R$ {0:F2}" + comissaoFuncionario.CalcularComissao());
            Console.WriteLine("Salário Total: " + comissaoFuncionario.CalcularSalarioTotal());
        }
    }
}