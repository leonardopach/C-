using System;

namespace StructFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros você vai digitar: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int result = 0;
            for (double i = 0; i < n; i++)
            {
                Console.Write($"Valor #{i + 1}: ");
                int somar = int.Parse(Console.ReadLine() ?? "0");
                result += somar;
            }
            Console.Write(result);
        }
    }
}