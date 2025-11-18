using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace dziedzicz
{
    internal class Program
    {
        public class Pojazd
        {
            private string Marka;
            private string Model;
            private int RokProdukcji;
            private decimal CenaDobowa;

            public virtual void WyswietlInformacje()
            {
                Console.WriteLine($"Marka:{Marka} Model:{Model} Rok:{RokProdukcji} Cena na dobe:{CenaDobowa}");
            }
            public Pojazd(string marka, string model, int rokProdukcji, decimal cenaDobowa)
            {
                this.Marka = marka;
                this.Model = model;
                this.RokProdukcji = rokProdukcji;
                this.CenaDobowa = cenaDobowa;
            }
            public virtual decimal ObliczKosztWypozyczenia(int liczbaDni)
            {
                return CenaDobowa * liczbaDni;
            }
        }
        public class Samochod:Pojazd
        {
            private int LiczbaMiejsc;
            public Samochod(string mar,string mod,int rokpr,decimal cen, int liczbami): base(mar, mod, rokpr, cen)
            { 
                LiczbaMiejsc = liczbami;
            }
            public override decimal ObliczKosztWypozyczenia(int liczbaDni)
            {
                if (LiczbaMiejsc > 5)
                {
                    return 50*liczbaDni;
                }
                else
                {
                    return base.ObliczKosztWypozyczenia(liczbaDni);
                }
            }
            public override void WyswietlInformacje()
            {
                base.WyswietlInformacje();
                Console.WriteLine($"Miejsca:{LiczbaMiejsc}");
            }
        }
        public class Motocykl : Pojazd
        {
            private int PojemnoscSilnika;
            public Motocykl(string mar, string mod, int rokpr, decimal cen, int Poj) : base(mar, mod, rokpr, cen)
            {
                PojemnoscSilnika = Poj;
            }
            public override void WyswietlInformacje()
            {
                base.WyswietlInformacje();
                Console.WriteLine($"Pojemność:{PojemnoscSilnika}");
            }
            public override decimal ObliczKosztWypozyczenia(int liczbaDni)
            {
                if (PojemnoscSilnika > 600)
                {
                    return 30*liczbaDni;
                }
                else
                {
                    return base.ObliczKosztWypozyczenia(liczbaDni);
                }
            }
        }
        static void Main(string[] args)
        {
            Pojazd[] pojazdy = new Pojazd[4];
            pojazdy[0] = new Samochod("ogorek","kielbasa",2018,200,4);
            pojazdy[1] = new Motocykl("jablko","gruszka",1996,200,606);
            pojazdy[2] = new Samochod("Toyota", "Yaris", 2008, 207, 6);
            pojazdy[3] = new Motocykl("", "kielbasa", 2018, 200, 400);
            for (int i = 0; i < 4; i++)
            {
                pojazdy[i].WyswietlInformacje();
                Console.WriteLine(pojazdy[i].ObliczKosztWypozyczenia(7));
            }
        }
    }
}
