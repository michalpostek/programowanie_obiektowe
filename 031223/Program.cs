// Wariant 6
class Szkola {
    public static int liczbaUczniow;
    public static int liczbaLawek;

    public Szkola(int initLiczbaUczniow, int initLiczbaLawek) {
        liczbaUczniow = initLiczbaUczniow;
        liczbaLawek = initLiczbaLawek;
    }

    public void SprawdzLawki() {
        bool isEnough = !(liczbaUczniow > liczbaLawek * 2);

        Console.WriteLine("Ławek {0} wystarczy dla wszystkich uczniów", isEnough ? "" : "nie");
    } 
}

class Program {
    public static void Main(string[] args) {
        Szkola szkola1 = new Szkola(11, 6);
        szkola1.SprawdzLawki();
    }
}