namespace Zadanie11
{
    class Zadanie11
    {
        public static void ShowExample()
        {
            int sum = 0;
            int counter = 0;

            while (sum < 100)
            {
                sum += ++counter;
            }

            Console.WriteLine("Aby otrzymac 100 nalezy dodac do siebie kolejne liczby od 1 do {0}", counter);
        }
    }
}
