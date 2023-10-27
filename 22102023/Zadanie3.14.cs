namespace Zadanie14 {
    class Zadanie14 {
        public static void ShowExample() {
            Console.WriteLine("Podaj n");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++) {
                if (Zadanie14.IsNumberPerfect(i)) {
                    Console.WriteLine("{0} jest liczba doskonala", i);
                }
            }
        }

        private static bool IsNumberPerfect(int n) {
            int sum = 0;

            for (int i = 1; i < n; i++) {
                if (n % i == 0) {
                    sum += i;
                }
            }

            return sum == n;
        }
    }
}