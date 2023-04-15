using System;

namespace Casting {
    class Program {
        static void Main(string[] args) {

            double a;
            int b;
            
            a = 5.1;
            b = (int)a; // casting

            Console.WriteLine(b);

            int c = 5;
            int d = 2;

            double resultado = (double)c / d;
            Console.WriteLine($"o resultado de 5 / 2 é = {resultado}");

        }
    }
}
