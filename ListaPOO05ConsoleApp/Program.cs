namespace ListaPOO05ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            esfera.volume = 0;
            esfera.raio = 5;

            Console.WriteLine("O volume da esfera é: " + esfera.Calcular());
        }
    }
}