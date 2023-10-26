namespace Zadanie2
{
    public class Zadanie2  {
        public static void ShowExample()
        {
            double a = getDouble("Podaj a");
            double b = getDouble("Podaj b");
            double c = getDouble("Podaj c");

            double delta = calculateDelta(a, b, c);

            Console.WriteLine("Delta = {0}", delta);
        }

        private static double calculateDelta(double a, double b, double c) {
            return b * b - 4 * a * c;
        }  

        private static double getDouble(string text = "") {
            string? input = null;

            while (input == null) {
                Console.WriteLine("{0}", text);
                input = Console.ReadLine();
            }

            return double.Parse(input);
        }
    }
}