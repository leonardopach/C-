using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalTernaria {
    internal class Program {
        static void Main(string[] args) {

            int valor = Convert.ToInt16(Console.ReadLine());

            double desconto = (valor < 20) ? valor * 0.1 : valor * 0.05;
            Console.WriteLine(desconto);
        }
    }
}
