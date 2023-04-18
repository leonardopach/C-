using System;

namespace ExercicioList {
    internal class Employees {
        private int Id { get; set; }
        private string Name { get; set; }
        private double Salary { get; set; }

        public Employees() {

        }
        public Employees(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public int Idd() {
            return Id;
        }
        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString() {
            return $"Id: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Salary: {Salary}";
        }
    }
}
