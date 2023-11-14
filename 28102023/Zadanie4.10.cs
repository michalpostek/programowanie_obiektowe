namespace Zadanie10
{
    class Zadanie10
    {
        private static string[] months =
        {
            "Styczen",
            "Luty",
            "Marzec",
            "Kwiecien",
            "Maj",
            "Czerwiec",
            "Lipiec",
            "Sierpien",
            "Wrzesien",
            "Pazdziernik",
            "Listopad",
            "Grudzien"
        };

        public static void ShowExample()
        {
            Console.WriteLine("Podaj date w formacie DD-MM-RRRR");
            string date = Console.ReadLine();
            int monthNumber = Int32.Parse(date.Split("-")[1]);

            Console.WriteLine("Podany miesiac to {0}", months[--monthNumber]);
        }
    }
}
