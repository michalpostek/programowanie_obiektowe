namespace Zadanie10 {
    class Zadanie10 {
        public static void ShowExample() {
            Console.WriteLine("Podaj n");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = Zadanie10.Factorial(n);

            Console.WriteLine("{0}! = {1}", n, factorial);
        }

        private static int Factorial(int n) {
            if (n == 0 || n == 1) {
                return 1;
            }

            return n * Zadanie10.Factorial(n - 1);
        }
    }
}