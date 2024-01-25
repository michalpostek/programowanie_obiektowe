namespace Zadanie3
{
    class Zadanie3
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj liczbe calkowita z przedziału <0; 150>");
            int n = Math.Abs(int.Parse(Console.ReadLine()));

            if (n > 150)
            {
                n = 150;
            }

            int[] numbers = Zadanie3.GetRandomArray(n);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Zadanie3.FindGreatestNumber(numbers);
        }

        private static void FindGreatestNumber(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("Tablica jest pusta");

                return;
            }

            if (numbers.Length == 1)
            {
                Console.WriteLine("Najwiekszy element to {0} i występuje on 1 raz", numbers[0]);

                return;
            }

            int currentMaxCount = 1;
            int currentMax = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == currentMax)
                {
                    currentMaxCount++;
                }
                else if (numbers[i] > currentMax)
                {
                    currentMax = numbers[i];
                    currentMaxCount = 1;
                }
            }

            Console.WriteLine(
                "Najwiekszy element tablicy to {0} i wystepuje on {1} raz/razy",
                currentMax,
                currentMaxCount
            );
        }

        private static int[] GetRandomArray(int n)
        {
            int[] numbers = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = rand.Next(-1109, 1110);
            }

            return numbers;
        }
    }
}
