namespace Zadanie1
{
    class Zadanie1
    {
        public static void ShowExample()
        {
            int[] arr = Zadanie1.GetIntArray();
            Console.WriteLine("Wpisane liczby: {0}", string.Join(", ", arr));
        }

        public static int[] GetIntArray()
        {
            Console.WriteLine("Podaj ilosc elementow");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Podaj {0} liczbe", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            return numbers;
        }
    }
}