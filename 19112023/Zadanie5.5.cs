namespace Zadanie5
{
    class Zadanie5
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj szerokosc");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokosc");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj znak");
            char character = Console.ReadLine()[0];
        
            Zadanie5.DrawRectangle(width, height, character);
            Zadanie5.DrawRectangle(height, width, character);
        }

        private static void DrawRectangle(int width, int height, char character)
        {
            Console.WriteLine("");
            
            for (int j = 0; j < height; j++)
            {
                Console.WriteLine(new string(character, width));
            }
        }
    }
}
