namespace Zadanie1
{
    class Zadanie1
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj a");
            double a = double.Parse(Console.ReadLine());
            double b = 2;
            Console.WriteLine("Podaj c");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("f(x) = {0}x^2 + {1}x + {2}", a, b, c);
            Zadanie1.ShowSolutions(a, b, c);
        }

        private static void ShowSolutions(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Brak rozwiazan dla podanego rownania ");
            }
            else if (delta == 0)
            {
                double x0 = -b / 2 * a;

                Console.WriteLine("Rozwiazanie: {0}", x0);
            }
            else
            {
                double squaredDelta = Math.Sqrt(delta);
                double x1 = (-b - squaredDelta) / (2 * a);
                double x2 = (-b + squaredDelta) / (2 * a);

                Console.WriteLine("Rozwiązania równania to {0} oraz {1}", x1, x2);
            }
        }
    }
}
