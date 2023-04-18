using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ExercicioList {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered: ");
            int qtd = Convert.ToInt32(Console.ReadLine());
            List<Employees> list = new List<Employees>();

            for (int i = 0; i < qtd; i++) {
                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Employees em = new Employees(id, name, salary);
                list.Add(em);
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = Convert.ToInt32(Console.ReadLine());

            Employees emp = list.Find(x => x.Idd() == idIncrease);

            if (emp == null) {
                Console.WriteLine("This id does not exist");
            } else {
                Console.Write("Enter the percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }

            for (int i = 0; i < qtd; i++) {
                Console.WriteLine();
                Console.WriteLine(list[i]);

            }

        }
    }
}
