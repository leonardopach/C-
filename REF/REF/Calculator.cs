
namespace REF {
    internal class Calculator {

        public static void Triple(ref int x) {
            x *= 3;
        }public static void Dobrar(int origin, out int result) {
            result = origin * 2;
        }
    }
}
