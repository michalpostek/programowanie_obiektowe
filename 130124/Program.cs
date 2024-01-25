
class Program {
    public static void Main(string[] args) {
        RachunekBankowy saver1 = new RachunekBankowy(2000);
        RachunekBankowy saver2 = new RachunekBankowy(3000);

        RachunekBankowy.setRocznaStopaProcentowa(0.04);
        saver1.obliczMiesieczneOdsetki();
        saver2.obliczMiesieczneOdsetki();

        Console.WriteLine("Saldo saver1 po 1 miesiacu: {0:0.00} PLN", saver1.saldo);
        Console.WriteLine("Saldo saver2 po 1 miesiacu: {0:0.00} PLN", saver2.saldo);
    
        RachunekBankowy.setRocznaStopaProcentowa(0.05);
        saver1.obliczMiesieczneOdsetki();
        saver2.obliczMiesieczneOdsetki();

        Console.WriteLine("Saldo saver1 po 2 miesiacu: {0:0.00} PLN", saver1.saldo);
        Console.WriteLine("Saldo saver2 po 2 miesiacu: {0:0.00} PLN", saver2.saldo);
    }
}

class RachunekBankowy {
    public static double rocznaStopaProcentowa;
    public double saldo;

    public RachunekBankowy(double initSaldo) {
        this.saldo = initSaldo;
    }

    public void obliczMiesieczneOdsetki() {
        double odsetki = this.saldo * rocznaStopaProcentowa / 12;
        this.saldo += odsetki;
    }

    public static void setRocznaStopaProcentowa(double stopa) {
        rocznaStopaProcentowa = stopa;
    }
}
