namespace Zadanie9
{
    class Zadanie9
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(
                "{0}-ty wyraz ciagu fibonacciego: {1}",
                n,
                Zadanie9.GetFibonacciElement(n)
            );

            Console.WriteLine(
                "{0}-ty wyraz ciagu fibonacciego uzywajac petli for: {1}",
                n,
                Zadanie9.GetFibonacciElement(n)
            );
        }

        private static int GetFibonacciElement(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Zadanie9.GetFibonacciElement(n - 1) + Zadanie9.GetFibonacciElement(n - 2);
        }

        private static int GetFibonacciElement2(int n) {
            if (n == 0 || n == 1) {
                return n;
            }

            int beforeLast = 0;
            int last = 1;
            
            for (int i = 2; i < n; i++) {
                int temp = beforeLast + last;
                beforeLast = last;
                last = temp;
            }

            return last;
        }
    }
}
