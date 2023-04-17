namespace Encapsulamento {
    internal class Produto {

        private string? _nome;
        public double Preco {
            get; private set;
        }
        public int Quantidade {
            get; private set;
        }
        //private int _quantidade;
        public Produto() {

        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            //_preco = preco;
            //_quantidade = quantidade;
        }

        public string? Nome {
            get {
                return _nome;
            }
            set {
                _nome = value;
            }
        }

        //public double Preco {
        //    get {
        //        return _preco;
        //    }
        //}
        //public int Quantidade {
        //    get {
        //        return _quantidade;
        //    }
        //}
        //public string? GetNome() {
        //    return _nome;
        //}

        //public double GetPreco() {
        //    return _preco;
        //}

        //public void SetNome(string nome) {
        //    _nome = nome;
        //}
        //public int GetQuantidade() {
        //    return _quantidade;
        //}
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return $"{Nome}, {Preco}, {Quantidade}";
        }
    }
}
