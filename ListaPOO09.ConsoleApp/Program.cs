namespace ListaPOO09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica mediaHarmonica = new MediaHarmonica();
            mediaHarmonica.nota1 = 6;
            mediaHarmonica.nota2 = 7;
            mediaHarmonica.nota3 = 8;
            mediaHarmonica.nota4 = 9;
            mediaHarmonica.media = 0;

            Console.WriteLine("A média é: " + mediaHarmonica.CalcularNota());
        }
    }
}