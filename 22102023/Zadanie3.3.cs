namespace Zadanie3
{
    class Zadanie3
    {
        public static void ShowExample()
        {
            float a = Zadanie3.GetFloat("Podaj a");
            float b = Zadanie3.GetFloat("Podaj b");
            float c = Zadanie3.GetFloat("Podaj c");

            float greatest = Zadanie3.GreatestNumber(a, b, c);

            Console.WriteLine("Najwieksza liczba sposrod podanych to {0}", greatest);
        }

        private static float GreatestNumber(float x, float y, float z)
        {
            if (x > y)
            {
                if (x > z)
                {
                    return x;
                }

                return z;
            }

            if (y > z)
            {
                return y;
            }

            return z;
        }

        private static float GetFloat(string text)
        {
            Console.WriteLine(text);
            string input = Console.ReadLine() ?? "0";

            return float.Parse(input);
        }
    }
}