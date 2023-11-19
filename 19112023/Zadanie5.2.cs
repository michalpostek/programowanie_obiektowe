namespace Zadanie2 {
    class Zadanie2 {
        public static void ShowExample() {
            Console.WriteLine("Podaj a");
            double a = double.Parse(Console.ReadLine());
        
            Console.WriteLine("Podaj b");
            double b = double.Parse(Console.ReadLine());
        
            Console.WriteLine("Podaj x");
            double x = double.Parse(Console.ReadLine());
        
            bool IsInRange = Zadanie2.IsInRange(a, b, x);

            Console.WriteLine("Liczba {0}mieści się w przedziale", IsInRange ? "" : "nie ");
        }

        private static bool IsInRange(double min, double max, double value) {
            return value > min && value < max;
        }
    }
}