using System;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500, 10);

            p.Nome = "TV 4k";
            //p.SetNome("Geladeira");
            p.AdicionarProdutos(10);
            Console.WriteLine(p);
        }
    }
}