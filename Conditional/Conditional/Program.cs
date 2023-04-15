using System;

namespace Conditional {
    class Program {
        static void Main(string[] args) {
            int x = 12;

            if (x <= 12) {
                Console.WriteLine("Bom dia");
            } else if (x < 18) {
                Console.WriteLine("Boa tarde");
            } else {
                Console.WriteLine("Boa noite");
            }

            Console.WriteLine("Digite um Numero: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int numero)) {
                if (numero % 2 == 0) {
                    Console.WriteLine($"O {numero} é Par");
                } else {
                    Console.WriteLine($"O {numero} é Impar");
                }
            } else {
                Console.WriteLine("Entrada Inválida");
            }
        }
    }
}

