using System;

namespace ForEach {
    internal class Program {
        static void Main(string[] args) {

            string[] vect = new string[] { "Maria", "Alex", "Bobo" };

            foreach (string  obj in vect) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }
        }
    }
}
