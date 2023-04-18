using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace Vector {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine() ?? "0");

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine() ?? "0");
            }

            double sum = 0;
            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }
            Console.WriteLine(sum);

            int nn = int.Parse(Console.ReadLine() ?? "0");

            Product[] vects = new Product[nn];

            for (int i = 0; i < nn; i++) {
                string? name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine() ?? "0");
                vects[i] = new Product { Name = name, Price = price };
            }

            double? summ = 0.0;
            for (int i = 0; i < nn; i++) {
                summ += vects[i].Price;
            }
            double? avg = summ / nn;
            Console.WriteLine($"Avege = {avg}");

        }
    }
}