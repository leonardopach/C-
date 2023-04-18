namespace Vector {
    internal class Product {
        public string? Name { get; set; }
        public double? Price { get; set; }

        public Product() { }
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
        public void Triple(int x) {
            x *= 3;
        }
    }
}
