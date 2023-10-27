namespace Zadanie8
{
    class Zadanie8
    {
        public static void ShowExample()
        {
            Console.WriteLine("Podaj swoją średnią");
            float avg = float.Parse(Console.ReadLine());
            int scholarshipAmount = Zadanie8.GetScholarshipAmount(avg);

            Console.WriteLine("Przysługujące Ci stypendium to {0}.00zł", scholarshipAmount);
        }

        private static int GetScholarshipAmount(float avg)
        {
            if (avg < 4)
            {
                return 0;
            }

            if (avg < 4.8)
            {
                return 350;
            }

            return 550;
        }
    }
}