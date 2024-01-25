namespace Zadanie5 {
    class Point {
        public double x;
        public double y;

        public Point(double initialX, double initialY) {
            x = initialX;
            y = initialY;
        }

        public void Move(double offsetX, double offsetY) {
            x += offsetX;
            y += offsetY;
        }

        public void ShowCurrentCoordinates() {
            Console.WriteLine("Aktualne współrzędne punktu to ({0}, {1})", x, y);
        }

        public static bool ArePointsOnTheSameLine(Point[] points) {
            return false;
        }
    }
}