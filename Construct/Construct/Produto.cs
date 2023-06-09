﻿using System.Globalization;

namespace Construct
{
    internal class Produto
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 2;
        }
        public Produto(string? nome, double preco): this() {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string? nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }

        
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
