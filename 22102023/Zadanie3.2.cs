namespace Zadanie2
{
    class Zadanie2
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            int b = Convert.ToInt32(Console.ReadLine());

            bool isDivisor = Zadanie2.IsDivisor(a, b);

            Console.WriteLine("{0} {2} podzielne przez {1}", a, b, isDivisor ? "jest" : "nie jest");
        }

        private static bool IsDivisor(int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }
    }
}