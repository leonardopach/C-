using System;
using System.Collections.Generic;
using System.Linq;

namespace List {
    internal class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();
            list.Add("Pedro");
            list.Add("Alex");
            list.Add("Silva");
            list.Add("Ana");
            list.Insert(1, "Lucas");
            Console.WriteLine($"Tamanho: {list.Count}");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"First 'A': {s1}");
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First position 'A' {pos1}");
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"First position 'A' {pos2}");
            Console.WriteLine("--------------------------------");

            List<string> list3 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list3) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------------");
            var nomesComM = list.Where(n => n.StartsWith("A"));
            foreach (string obj in nomesComM) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------");
            List<string> list2 = new List<string>() { "Maria", "Alex", "Lucas" };

            foreach (string item in list2) {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------");
            list.Remove("Pedro");
            list.RemoveAll(x => x[0] == 'A');
            list.RemoveAt(0);
            list.RemoveRange(0, 1);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
