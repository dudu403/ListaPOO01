namespace ListaPOO10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularMedia media = new CalcularMedia();
            media.nota1 = 7;
            media.peso1 = 10;
            media.nota2 = 9;
            media.peso2 = 10;
            media.media = 0;

            Console.WriteLine("A média é: " + media.CalcularMediaNotas());
        }
    }
}