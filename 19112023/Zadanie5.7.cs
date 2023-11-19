namespace Zadanie7
{
    class Zadanie7
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj x");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(
                "W = (x+1) + (x+2) + (x+3) +.......+ (x+n) = {0}",
                Zadanie7.CalculateSeries(x, n)
            );
        }

        private static int CalculateSeries(int x, int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += x + i;
            }

            return sum;
        }
    }
}
