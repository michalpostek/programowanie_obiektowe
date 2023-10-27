namespace Zadanie6
{
    class Zadanie6
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj wage [kg]");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost [m]");
            float height = float.Parse(Console.ReadLine());

            float BMI = Zadanie6.CalculateBMI(weight, height);
            string bodyMassClasification = Zadanie6.GetBodyMassClasification(BMI);

            Console.WriteLine("Twoje BMI to {0} i oznacza to {1}", BMI, bodyMassClasification);
        }

        private static float CalculateBMI(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }

        private static string GetBodyMassClasification(float BMI)
        {
            if (BMI < 16)
            {
                return "Wygłodzenie";
            }

            if (BMI < 17)
            {
                return "Wychudzenie";
            }

            if (BMI < 18.5) {
                return "Niedowaga";
            }

            if (BMI < 25) {
                return "Pożądana masa ciała";
            }

            if (BMI < 30) {
                return "Nadwaga";
            }

            if (BMI < 35) {
                return "Otyłość I stopnia";
            }

            if (BMI < 40) {
                return "Otyłość II stopnia";
            }

            return "Otyłość III stopnia";
        }
    }
}