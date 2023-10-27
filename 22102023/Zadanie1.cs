namespace Zadanie1
{
    class Zadanie1
    {
        public static void ShowExample() {
            Console.WriteLine("Podaj rok");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeapYear = Zadanie1.IsLeapYear(year);

            Console.WriteLine("Podany rok {0} przestępny", isLeapYear ? "jest" : "nie jest");
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}