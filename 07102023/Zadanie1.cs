namespace Zadanie1
{
    public class Zadanie1
    {
        public static void ShowExample()
        {
            string? input = null;

            while (string.IsNullOrEmpty(input))
            {

                Console.WriteLine("Podaj temperature");
                input = Console.ReadLine();
            }

            float temp = float.Parse(input);

            Console.WriteLine("Temperatura: {0}C / {1}F", temp, CelsiusToFehrenheit(temp));
        }

        private static float CelsiusToFehrenheit(float x)
        {
            return 32 + 9f / 5f * x;
        }
    }
}