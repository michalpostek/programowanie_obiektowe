using PodrozNS;

class Program
{
    public static void Main(string[] args)
    {
        PlanTrip();
    }

    private static void PlanTrip()
    {
        Podroz podroz = new Podroz();
        bool userStopped = false;

        while (!userStopped)
        {
            string userInput = GetUserInput();

            if (userInput == "A")
            {
                HandleAddBus(ref podroz);
            }
            else if (userInput == "P")
            {
                HandleAddTrain(ref podroz);
            }
            else if (userInput == "U")
            {
                HandleRemoveLast(ref podroz);
            }
            else if (userInput == "Z")
            {
                HandleShowTripPlan(ref podroz);
            }
            else if (userInput == "D")
            {
                HandleCheckTripDate(ref podroz);
            }
            else if (userInput == "S")
            {
                Console.WriteLine("Zakończono planowanie podróży");
                userStopped = true;
            }
            else if (userInput == "F")
            {
                HandleSetTripDate(ref podroz);
            }
        }
    }

    private static void HandleAddBus(ref Podroz podroz)
    {
        Console.WriteLine("Podaj ilosc miejsc");
        int? iloscMiejsc = null;

        try
        {
            iloscMiejsc = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Podano nieprawidlowa wartosc \n");
        }

        if (iloscMiejsc == null || !(iloscMiejsc > 0))
        {
            return;
        }

        podroz.DodajAutobus((int)iloscMiejsc);
        Console.WriteLine("Pomyślnie dodano autobus \n");
    }

    private static void HandleAddTrain(ref Podroz podroz)
    {
        Console.WriteLine("Podaj ilosc miejsc");
        int? iloscMiejsc = null;

        try
        {
            iloscMiejsc = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Podano nieprawidlowa wartosc \n");
        }

        if (iloscMiejsc == null || !(iloscMiejsc > 0))
        {
            return;
        }

        Console.WriteLine("Podaj dlugosc trasy");
        int? dlugoscTrasy = null;

        try
        {
            dlugoscTrasy = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Podano nieprawidlowa wartosc \n");
        }

        if (dlugoscTrasy == null || !(dlugoscTrasy > 0))
        {
            return;
        }

        podroz.DodajPociag((int)iloscMiejsc, (int)dlugoscTrasy);
        Console.WriteLine("Pomyślnie dodano pociąg \n");
    }

    private static void HandleRemoveLast(ref Podroz podroz)
    {
        Console.WriteLine("Usuwam ostatni srodek lokomocji \n");
        podroz.UsunOstatni();
    }

    private static void HandleShowTripPlan(ref Podroz podroz)
    {
        Console.WriteLine("Plan podróży: ");
        Console.WriteLine(podroz.ToString());
    }

    private static void HandleCheckTripDate(ref Podroz podroz)
    {
        if (!podroz.SprawdzDate())
        {
            Console.WriteLine("Twoja podróż już się odbyła \n");
        }
        else
        {
            Console.WriteLine("Twoja podróż jeszcze się nie odbyła \n");
        }
    }

    private static void HandleSetTripDate(ref Podroz podroz)
    {
        Console.WriteLine("Podaj date podróży w formacie DD.MM.YYYY");
        DateTime? userInput = null;

        try
        {
            userInput = DateTime.Parse(Console.ReadLine() ?? "");
        }
        catch
        {
            Console.WriteLine("Podano nieprawidlowa date \n");
        }

        if (userInput == null)
        {
            return;
        }

        Console.WriteLine("Ustawiono date podróży na {0} \n", userInput.ToString());
        podroz.UstawDate((DateTime)userInput);
    }

    private static string GetUserInput()
    {
        Console.WriteLine("[F] - Ustaw date podróży \n[A] - Dodaj autobus \n[P] - Dodaj pociąg \n[U] - Usuń ostatnią pozycję z planu podróży \n[Z] - Pokaż plan podróży \n[D] - Sprawdź datę podróży \n[S] - Zakończ planowanie podróży");
        string? input = Console.ReadLine();

        return input ?? "";
    }
}
