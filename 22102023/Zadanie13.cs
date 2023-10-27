namespace Zadanie13
{
    class Zadanie13
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj n");
            int n = Convert.ToInt32(Console.ReadLine());
            n = n < 0 ? -n : n;
            int seriesSum = Zadanie13.SumOfSeries(n);

            Console.WriteLine("Suma szeregu to {0}", seriesSum);
        }

        private static int SumOfSeries(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++) { 
                if (i % 2 != 0) {
                    sum += i;
                } else {
                    sum -= i;
                }
            }

            return sum;
        }
    }
}