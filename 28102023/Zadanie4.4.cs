namespace Zadanie4 {
    class Zadanie4 {
        private static readonly Random rand = new Random();

        public static void ShowExample() {
            int[] numbers = Zadanie4.GetRandomNumbers(100);
            int[] primeNumbers = new int[100];

            foreach (int num in numbers) {
                if (Zadanie4.IsPrimeNumber(num)) {
                    primeNumbers[primeNumbers.Length] = num;
                }
            }

            Console.WriteLine(primeNumbers.Length);

            Console.WriteLine("Wylosowane liczby pierwsze: {0}", string.Join(", ", primeNumbers));
        }

        private static bool IsPrimeNumber(int n) {
            if (!(n > 1)) {
                return false;
            }

            for (int i = 2; i < n; i++) {
                if (n % i == 0) {
                    return false;
                }
            }

            return true;
        }

        private static int[] GetRandomNumbers(int len) {
            int[] numbers = new int[len];
            
            for (int i = 0; i < len; i++) {
                numbers[i] = Zadanie4.rand.Next(1, 10);
            }

            return numbers;
        }
    }
}