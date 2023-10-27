namespace Zadanie5
{
    class Zadanie5
    {
        public static void ShowExample()
        {
            float a = Zadanie5.GetFloat("Podaj a");
            float b = Zadanie5.GetFloat("Podaj b");
            float c = Zadanie5.GetFloat("Podaj c");

            if (a == 0) {
                Console.WriteLine("To nie jest rownanie kwadratowe");

                return;
            }

            int solutionsNumber = Zadanie5.SolutionsNumber(a, b, c);

            Console.WriteLine("Liczba rozwiazan rownania {0}x^2 + {1}x + {2} to {3}", a, b, c, solutionsNumber);
        }

        private static int SolutionsNumber(float a, float b, float c)
        {
            float delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                return 2;
            }

            if (delta == 0)
            {
                return 1;
            }

            return 0;
        }

        private static float GetFloat(string text) {
            Console.WriteLine(text);

            return float.Parse(Console.ReadLine());
        }
    }
}