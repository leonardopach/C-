using System;
using System.Runtime.InteropServices;

namespace Matriz {
    internal class Program {
        static void Main(string[] args) {

            double[,] data = new double[2, 3];
            Console.WriteLine(data.Length);
            Console.WriteLine(data.Rank);

            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("Main diagonal");
            for (int i = 0;i < n; i++) {
                Console.WriteLine(mat[i,i] + " ");
            }
            Console.WriteLine();
        }
    }
}
