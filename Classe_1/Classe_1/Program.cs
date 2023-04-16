using System;
using System.Globalization;

namespace Classe_1 {
    class Program {
        static void Main(string[] args) {
            Exibir_produto();
            Exibir_Triangulo();

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circuferência {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PI {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        static public void Exibir_produto() {
            Product x;
            x = new Product();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Dados do produto: {x}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int valor = int.Parse(Console.ReadLine() ?? "0");
            x.AdicionarProdutos(valor);
            Console.WriteLine($"Dados Atualizados: {x}");
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            int remover = int.Parse(Console.ReadLine() ?? "0");
            x.RemoverProdutos(remover);
            Console.WriteLine($"Dados Atualizados: {x}");

        }
        static public void Exibir_Triangulo() {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as Medidas do triângulo X");
            x.A = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as Medidas do triângulo Y");
            y.A = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            double AreaX = x.Area();
            double AreaY = y.Area();

            Console.WriteLine($"Area do Triângulo X {AreaX.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Triângulo Y {AreaY.ToString("F3", CultureInfo.InvariantCulture)}");

            if (AreaY > AreaX) {
                Console.WriteLine("Maior área: Y");
            }
            else {
                Console.WriteLine("Maior área: X");
            }
        }
    }
}