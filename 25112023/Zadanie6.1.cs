namespace Zadanie1
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double x, double y)
        {
            width = x;
            length = y;
        }

        public void Show()
        {
            Console.WriteLine(
                "Powierzchnia prostokąta wynosi {0}, a jego obwód {1}",
                Area(),
                Circumference()
            );
        }

        public static double LargestArea(Rectangle[] rectangles) {
            double largestArea = 0;

            foreach (Rectangle rectangle in rectangles) {
                double area = rectangle.Area();
                
                if (area > largestArea) {
                    largestArea = area;
                }
            }

            return largestArea;
        } 

        private double Area()
        {
            return length * width;
        }

        private double Circumference()
        {
            return length * 2 + width * 2;
        }
    }
}
