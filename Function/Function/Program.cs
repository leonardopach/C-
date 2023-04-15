using System;

namespace Function {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite três Numeros: ");

            int num1 = int.Parse(Console.ReadLine() ?? "0");
            int num2 = int.Parse(Console.ReadLine() ?? "0");
            int num3 = int.Parse(Console.ReadLine() ?? "0");
            double resultado = Maior(num1, num2, num3);

            Console.WriteLine($"O Maior e o {resultado}");
        }
        static int Maior(int n1, int n2, int n3) {
            int resultado = 0;
            if (n1 > n2 && n1 > n3) {
                resultado = n1;
            } else if (n2 > n3) {
                resultado = n2;
            } else {
                resultado = n3;
            }
            return resultado;
        }
    }

}