namespace Zadanie3
{
    class Zadanie3
    {
        public static void ShowExample()
        {
            double[] pointCoordinates = new double[2];
            double[] wec = new double[2] { 3, 2 };

            Console.WriteLine("Podaj wspolrzedna x");
            pointCoordinates[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedna y");
            pointCoordinates[1] = double.Parse(Console.ReadLine());

            Console.WriteLine(
                "Podany punkt to ({0}, {1}) ",
                pointCoordinates[0],
                pointCoordinates[1]
            );

            Zadanie3.Move(ref pointCoordinates[0], ref pointCoordinates[1], wec[0], wec[1]);

            Console.WriteLine(
                "Podany punkt po przesunieciu o wector [{0}, {1}] to ({2}, {3}) ",
                wec[0],
                wec[1],
                pointCoordinates[0],
                pointCoordinates[1]
            );
        }

        private static void Move(ref double x, ref double y, double xOffset, double yOffset)
        {
            x += xOffset;
            y += yOffset;
        }
    }
}
