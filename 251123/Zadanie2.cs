namespace Zadanie2
{
    class Zadanie2
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj M");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj N");
            int N = int.Parse(Console.ReadLine());

            Zadanie2.ShowValues(M, N);
            Zadanie2.Swap(ref M, ref N);
            Console.WriteLine("Wartosci zostały zamienione");
            Zadanie2.ShowValues(M, N);
        }

        public static void ShowValues(int M, int N)
        {
            Console.WriteLine("M = {0}, N = {1}", M, N);
        }

        public static void Swap(ref int M, ref int N)
        {
            (M, N) = (N, M);
        }
    }
}
