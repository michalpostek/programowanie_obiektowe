namespace CarNS {
    class Car {
        public static int wheelsAmount;
        private double engineVolume;
        private string make;

        static Car() {
            Car.wheelsAmount = 4;
        }

        public static Car Create(string make, int engineVolume) {
            return new Car(make, engineVolume);
        }

        private Car(string make, int engineVolume) {
            this.engineVolume = engineVolume;
            this.make = make;
        }

        private Car(int engineVolume, string make) {
            this.engineVolume = engineVolume;
            this.make = make;
        }
    }
}
