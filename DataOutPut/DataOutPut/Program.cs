using System;
using System.Globalization;

namespace DataOutPut {
    class Programa {
        static void Main(string[] args) {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia");
            Console.WriteLine("Boa Tarde");
            Console.WriteLine("Boa noite");
            Console.WriteLine("----------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1}, em sua conta tem o saldo de {2:F3}", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} e seu saldo e de {saldo:F2}");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
