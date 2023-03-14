namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.Write("Insira a temperatura em graus Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius é: {0}", celsius);

            Console.ReadKey();
        }
    }
}