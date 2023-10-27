namespace Zadanie7 {
    class Zadanie7 {
        public static void ShowExample() {
            Console.WriteLine("Podaj swoją średnią");
            float avg = float.Parse(Console.ReadLine());
            int scholarshipAmount = Zadanie7.GetScholarshipAmount(avg);

            Console.WriteLine("Przysługujące Ci stypendium to {0}.00zł", scholarshipAmount);
        }

        private static int GetScholarshipAmount(float avg) {
            switch (avg) {
                case var expression when avg < 4:
                    return 0;
                case var expression when avg < 4.8:
                    return 350;
                default:
                    return 550;
            }
        }
    }
}