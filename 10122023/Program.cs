using CarNS;

class Program {
    public static void Main(string[] args) {
        // Car testCar = new Car("Opel", 1410);
        // cannot access private field
        // string TestCarMAke = testCar.make;
        // Car myCar = new Car(1910, "Alfa Romeo");
        Car car = Car.Create("Alfa Romeo", 1910);
        // iloscKol = 4
    
    }
}