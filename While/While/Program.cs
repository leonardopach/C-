using System;
using System.Globalization;

namespace Whilee {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero: ");
            double numero = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

            double condicao = 0;
            while (condicao <= numero) {
                Console.WriteLine(condicao.ToString("F1", CultureInfo.InvariantCulture));
                condicao++;
            }
        }
    }
}