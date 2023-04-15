using System;

namespace Split {
    class Program {
        static void Main(string[] args) {

            string? input = Console.ReadLine();
            if (input is not null) {
                string[] separador = input.Split(' ');
                int num1 = int.Parse(separador[0]);
                int num2 = int.Parse(separador[1]);
                int soma = num1 + num2;
                Console.WriteLine(soma);
            }
        }
    }
}