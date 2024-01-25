class Program
{
    private static void Main(string[] args)
    {
        Blackjack blackjack = new Blackjack();

        blackjack.Start();
    }
}

enum DeckType
{
    NORMAL,
    SMALL
}

class Blackjack
{
    private readonly int players;
    private readonly int[] deck;
    private readonly bool autoWin;
    private readonly static Random random = new Random();

    public Blackjack()
    {
        this.players = 2;
        this.deck = GetDeck(DeckType.NORMAL);
    }

    public Blackjack(int players, DeckType deckType, bool autoWin)
    {
        this.players = players;
        this.deck = GetDeck(deckType);
        this.autoWin = autoWin;
    }

    public void Start()
    {
        int[] results = new int[players];

        for (int i = 0; i < players; i++)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("player{0} turn", i + 1);
            Console.WriteLine("----------------------");
            bool isLast = i - 1 == players;
            bool playerStopped = false;
            int currentPlayerScore = 0;

            while (currentPlayerScore < 21 && !playerStopped)
            {
                if (isLast && currentPlayerScore > results.Max()) {
                    playerStopped = true;

                    continue;
                }

                int card = GetRandomCard(deck);
                bool playerWantTextCard = CheckIfPlayerWantNextCard();
                currentPlayerScore += card;
                DisplayGameState(i + 1, card, currentPlayerScore);

                if (currentPlayerScore > 21 || !playerWantTextCard)
                {
                    playerStopped = true;
                }

                if (currentPlayerScore > 21)
                {
                    Console.WriteLine("Player {0} lost", i + 1);
                }
            }

            results[i] = currentPlayerScore;
        }

        for (int i = 0; i < results.Length; i++) {
            Console.WriteLine("Player {0} result is {1}", i + 1, results[i]);
        }
    }

    private static void DisplayGameState(int player, int newCard, int newScore)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Playing as player {0}", player);
        Console.WriteLine("You drew {0}! Your score is now {1}", newCard, newScore);
        Console.WriteLine("----------------------------------");
    }

    private static bool CheckIfPlayerWantNextCard()
    {
        string? input = null;

        while (input?.ToLower() != "n" && input?.ToLower() != "s")
        {
            Console.WriteLine("Type 'n' for next card or 's' to stop");
            input = Console.ReadLine();
        }

        return input == "n";
    }

    private static int GetRandomCard(int[] cards)
    {
        int index = random.Next(0, cards.Length);

        return cards[index];
    }

    private static int[] GetDeck(DeckType type)
    {
        if (type == DeckType.SMALL)
        {
            int[] deck = { 0, 10, 2, 3, 4, 11 };

            return deck;
        }
        else
        {

            int[] deck = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 };

            return deck;
        }
    }
}