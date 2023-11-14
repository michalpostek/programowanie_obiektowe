namespace Zadanie8
{
    class Zadanie8
    {
        private const int daysCount = 7;
        private const int dictionariesCount = 3;

        public static string[] daysInPl = new string[daysCount]
        {
            "poniedzialek",
            "wtorek",
            "środa",
            "czwartek",
            "piątek",
            "sobota",
            "niedziela"
        };
        public static string[] daysInEn = new string[daysCount]
        {
            "monday",
            "tuesday",
            "wednesday",
            "thursday",
            "friday",
            "saturday",
            "sunday"
        };
        public static string[] daysInDe = new string[daysCount]
        {
            "montag",
            "dienstag",
            "mittwoch",
            "donnerstag",
            "freitag",
            "samstag",
            "sonntag"
        };

        public static void ShowExample()
        {
            string[][] daysDictionary = new string[dictionariesCount][]
            {
                daysInPl,
                daysInEn,
                daysInDe
            };

            for (int j = 0; j < daysCount; j++)
            {
                string[] currentDayTranslations = new string[dictionariesCount];

                for (int i = 0; i < dictionariesCount; i++)
                {
                    currentDayTranslations[i] = daysDictionary[i][j];
                }

                Console.WriteLine("{0}", string.Join(", ", currentDayTranslations));
            }

            // dniTygodnia = new string[7, 3] = { daysInPl, daysInEn, daysInDe };
            // // dniTygodnia[0, 0] = "poniedzialek";
            // dniTygodnia[1, 0] = "wtorek";
            // dniTygodnia[0, 1] = "monday";
            // dniTygodnia[1, 1] = "tuesday";
            // dniTygodnia[0, 2] = "montag";
            // dniTygodnia[1, 2] = "dienstag";
        }
    }
}
