using System.Security.Cryptography.X509Certificates;

namespace ListaPOO08.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lataDeOleo = new LataDeOleo();
            lataDeOleo.altura = 10;
            lataDeOleo.raio = 6;
            lataDeOleo.volume = 0;

            Console.WriteLine("O volume da lata é: " + lataDeOleo.Calcular());

            
        }
    }
}