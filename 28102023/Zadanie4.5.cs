namespace Zadanie5
{
    class Zadanie5
    {
        public static void ShowExample()
        {
            Random random = new Random();
            Console.WriteLine("Podaj dlugosc tablicy");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++) {
                arr[i] = random.Next(1, 100);
            }

            arr2[0] = arr[arr.Length - 1];
            for (int i = 1; i < n; i++) {
                arr2[i] = arr[i - 1]; 
            }

            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(string.Join(", ", arr2));
        }
    }
}