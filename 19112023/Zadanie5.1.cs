namespace Zadanie1
{
    class Zadanie1
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj temperature (F)");
            float temp = float.Parse(Console.ReadLine());

            Console.WriteLine(
                "Podana temperature to {0} (C)",
                Zadanie1.ConvertFahrenheitToCelsius(temp)
            );
        }

        private static float ConvertFahrenheitToCelsius(float temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }
}
