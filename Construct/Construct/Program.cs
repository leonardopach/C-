using System;
using System.Globalization;

namespace Construct {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string? nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int qtd = int.Parse(Console.ReadLine() ?? "0");


            Produto p = new Produto(nome, preco);
            //Produto p = new Produto() {
            //    Nome = "TV",
            //    Preco = 900.0,
            //    Quantidade = 9
            //};

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine() ?? "0");
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine() ?? "0");
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}