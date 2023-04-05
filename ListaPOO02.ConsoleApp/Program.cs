using System.Security.Cryptography.X509Certificates;

namespace ListaPOO02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConverterFahreParaCelsius temperatura = new ConverterFahreParaCelsius();
            temperatura.Fahrenheit = 20;
            temperatura.Celsius = 0;

            Console.WriteLine("A temperatura em Celsius é:" + temperatura.Converter());
        }
    }
}