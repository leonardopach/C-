namespace Tipos {
    class Program {
        static void Main(string[] args) {
            Point p, p1, p2;

            p.X = 10;
            p.Y = 10;
            Console.WriteLine(p);

            p1 = new Point() {
                X = 10,
                Y = 30
            };

            p2 = p1;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}

