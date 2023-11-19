namespace Zadanie4
{
    class Zadanie4
    {
        public static void ShowExample()
        {
            int[] arr = { 1, 52, 63, 12, 53, 2, 1 };
            int multiplier = 2;

            Console.WriteLine("Tablica: {0}", string.Join(", ", arr));

            Zadanie4.MultiplyArray(arr, 2);

            Console.WriteLine(
                "Tablica pomnozona przez {0}: {1}",
                multiplier,
                string.Join(", ", arr)
            );

            int[] arr2 = Zadanie4.GetMultipliedArray(arr, multiplier);

            Console.WriteLine(
                "Tablica pommozona przez {0} jeszcze raz: {1}",
                multiplier,
                string.Join(", ", arr2)
            );

            // Zad 6
            string[] arr3 = { "Ala", "Ma", "Kota" };
            Console.WriteLine("Tablica stringow: {0}", string.Join(", ", arr3));

            Zadanie4.MultiplyArray(arr3, multiplier);
            Console.WriteLine(
                "Tablica stringow po przemnozeniu przez {0}: {1}",
                multiplier,
                string.Join(", ", arr3)
            );
        }

        private static void MultiplyArray(int[] arr, int multiplier)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * multiplier;
            }
        }

        private static void MultiplyArray(string[] arr, int multiplier)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = string.Concat(Enumerable.Repeat(arr[i], multiplier));
            }
        }

        private static int[] GetMultipliedArray(int[] arr, int multiplier)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] * multiplier;
            }

            return result;
        }
    }
}
