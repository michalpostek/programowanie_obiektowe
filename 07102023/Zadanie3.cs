namespace Zadanie3
{
    public class Zadanie3
    {
        public static void ShowExample()
        {
            float weight = Zadanie3.GetFloat("Podaj mase ciała [kg]");
            float height = Zadanie3.GetFloat("Podaj wzrost [m]");
            float BMI = Zadanie3.CalculateBMI(weight, height);

            Console.WriteLine("Twoje BMI wynosi {0}", Math.Round(BMI, 2));
        }
        
        private static float CalculateBMI(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }

        private static float GetFloat(string text = "")
        {
            string? input = null;

            while (input == null)
            {
                Console.WriteLine("{0}", text);
                input = Console.ReadLine();
            }

            return float.Parse(input);
        }
    }
}