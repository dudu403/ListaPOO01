namespace ListaPOO06ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConverterCelsiusParaFahre temperatura = new ConverterCelsiusParaFahre();
            temperatura.fahrenheit = 0;
            temperatura.celsius = 25;

            Console.WriteLine("A temperatura em Fahrenheit é: " + temperatura.Converter());


        }
    }
}