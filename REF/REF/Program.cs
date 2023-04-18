
namespace REF {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine() ?? "0");

            int dobrar;
            Calculator.Dobrar(a, out dobrar);
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            Console.WriteLine(dobrar);

        }
    }

}
