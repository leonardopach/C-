using System;
using System.Diagnostics;
using System.Globalization;

namespace DataInput {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite alguma informacao: ");
            string? frase = Console.ReadLine();
            Console.WriteLine(frase);
            if (frase is not null) {
                string[] vet = frase.Split(' ');
                Console.WriteLine(vet[0]);
            }

            Console.WriteLine("Digite um numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1);

            Console.WriteLine("Digite um caracter");
            char? ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);

            Console.WriteLine("Digite um numero com virgula");
            double db = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(db);

            Console.WriteLine("Entre com seu nome completo: ");
            string? nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qtdQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu ultimo nome, idade e altura: ");
            string? info = Console.ReadLine();
            string[] recorte = info.Split(" ");
            if (recorte is not null) {
                string[] vet = info.Split(' ');
            }
            string nome = recorte[0];
            int idade = int.Parse(recorte[1]);
            double altura = double.Parse(recorte[2]);
            Console.WriteLine($" {nome} {idade} {altura}");
        }
    }
}