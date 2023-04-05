namespace ListaPOO01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();
            caixa.altura = 20;
            caixa.comprimento = 10;
            caixa.largura = 40;

            Console.WriteLine("O volume da caixa é: " +caixa.CalcularVolume() );


        }
    }
}