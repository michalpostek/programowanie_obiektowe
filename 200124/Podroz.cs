using SrodkiLokomocji;

namespace PodrozNS
{

    interface IZarzadzaj
    {
        public void DodajAutobus(int iloscMiejsc);
        public void DodajPociag(int iloscMiejsc, int dlugoscTrasy);
        public void UsunOstatni();
        public void Wyczysc();
    }

    interface IData
    {
        public void UstawDate(DateTime data);
        public bool SprawdzDate();
    }

    class Podroz : IData, IZarzadzaj
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy = new List<SrodekLokomocji>();
        private double koszt = 0;

        public void DodajAutobus(int iloscMiejsc)
        {
            Autobus autobus = new Autobus(iloscMiejsc);
            this.planPodrozy.Add(autobus);
            this.koszt += autobus.GetTicketPrice();
        }

        public void DodajPociag(int iloscMiejsc, int dlugoscTrasy)
        {
            Pociag pociag = new Pociag(dlugoscTrasy, iloscMiejsc);
            this.planPodrozy.Add(pociag);
            this.koszt += pociag.GetTicketPrice();
        }

        public void UsunOstatni()
        {
            if (this.planPodrozy.Any())
            {
                this.planPodrozy.RemoveAt(this.planPodrozy.Count - 1);
            }
            else
            {
                Console.WriteLine("Nie można usunąć ostatniego elementu ponieważ plan podróży jest pusty");
            }
        }

        public void Wyczysc()
        {
            this.planPodrozy.Clear();
        }

        public void UstawDate(DateTime data)
        {
            this.dataPodrozy = data;
        }

        public bool SprawdzDate()
        {
            return System.DateTime.Now < this.dataPodrozy;
        }

        public override string ToString()
        {
            if (planPodrozy.Count == 0) {
                return "Nie dodano jeszcze żadnego środku transportu";
            }

            string tripInfo = "";

            for (int i = 0; i < planPodrozy.Count; i++)
            {
                string transportType = GetTransportType(planPodrozy[i]);
                double ticketPrice = planPodrozy[i].GetTicketPrice();

                tripInfo += $"{i + 1}. srodek lokomocj: {transportType}, cena biletu: {ticketPrice}PLN \n";
            }

            return tripInfo;
        }

        private static string GetTransportType(SrodekLokomocji srodekLokomocji)
        {
            if (srodekLokomocji.GetType() == typeof(Pociag))
            {
                return "pociąg";
            }
            else
            {
                return "autobus";
            }
        }
    }
}