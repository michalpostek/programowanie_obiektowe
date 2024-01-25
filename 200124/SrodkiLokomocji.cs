namespace SrodkiLokomocji
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public SrodekLokomocji() { }

        public virtual void obliczCene()
        {
            this.cenaBiletu = 50;
        }

        public double GetTicketPrice()
        {
            return this.cenaBiletu;
        }
    }

    class Autobus : SrodekLokomocji
    {
        public Autobus(int iloscMiejsc)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.obliczCene();
        }

        public override string ToString()
        {
            return $"Autobus: ilość miejsc: {this.iloscMiejsc}, cena biletu: {this.cenaBiletu}.";
        }
    }

    class Pociag : SrodekLokomocji
    {
        private int dlugoscTrasy;

        public Pociag(int dlugoscTrasy, int iloscMiejsc)
        {
            this.dlugoscTrasy = dlugoscTrasy;
            this.iloscMiejsc = iloscMiejsc;
            this.obliczCene();
        }

        public override void obliczCene()
        {
            if (this.dlugoscTrasy > 100)
            {
                this.cenaBiletu = dlugoscTrasy * 1.43;
            }
            else
            {
                base.obliczCene();
            }
        }

        public override string ToString()
        {
            return $"Pociąg: ilość miejsc: {this.iloscMiejsc}, długość trasy: {this.dlugoscTrasy}, cena biletu: {this.cenaBiletu}.";
        }
    }
}