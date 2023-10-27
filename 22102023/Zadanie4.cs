namespace Zadanie4
{
    class Zadanie4
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj operacje [+, -, /, *]");
            string operation = Console.ReadLine() ?? "+";
            
            Console.WriteLine("Podaj a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2} = {3}", a, operation, b, Zadanie4.Calculate(operation, a, b));
        }

        private static double Calculate(string operation, double x, double y)
        {
            if (operation == "+")
            {
                return x + y;
            }
            if (operation == "-")
            {
                return x - y;
            }
            if (operation == "*")
            {
                return x * y;
            }
            if (operation == "/")
            {
                return x / y;
            }

            throw new Exception("Niepoprawny operator");
        }
    }
}