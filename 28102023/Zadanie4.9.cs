namespace Zadanie9
{
    class Zadanie9
    {
        public static void ShowExample() {
            Console.WriteLine("Napisz cokolwiek");
            string sentence = Console.ReadLine();

            Console.WriteLine("Twoje zdanie ma {0} słowa", sentence.Split(" ").Length);
         }
    }
}
