namespace Zadanie4
{
    class Zadanie4
    {
        public static void ShowExample() {
            bool stopPrompting = false;
            int sum = 0;
            int count = 0;

            while (!stopPrompting) {
                Console.WriteLine("Podaj liczbe");
                int x = int.Parse(Console.ReadLine());
                count++;
                sum += x;

                if (x == 0) { 
                    stopPrompting = true;
                }
            }

            float avg = sum / (float)count;

            Console.WriteLine(avg);
        }
    }
}