using System.Runtime.ConstrainedExecution;

namespace Produkt
{
    internal class Program
    {
        class Produkt
        {
            private string nazwa;
            private decimal cena;
            private int iloscNaMagazynie;

            public decimal Cena
            {
                get
                {
                    return cena;
                }
                set
                {
                    if (value <= 0) {
                        throw new ArgumentException("Cena musi być większa od 0");
                    }
                    else
                    {
                        cena = value;
                    }

                }
            }
            public int Ilosc
            {
                get
                {
                    return iloscNaMagazynie;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Ilość nie może być ujemna");
                    }
                    else
                    {
                        iloscNaMagazynie = value;
                    }

                }
            }
            public string Nazwa
            {
                get
                {
                    return nazwa;
                }
                set
                {
                    if (string.IsNullOrEmpty(value)) {
                        throw new ArgumentException("Nazwa nie może być pusta");
                    }
                }
            }
            public Produkt(string naz , int cena , int ilosc)
            {
                this.nazwa = naz;
                this.cena = cena;
                this.iloscNaMagazynie = ilosc;
            }
            public override string ToString()
            {
                return $"nazwa:{nazwa} cena:{cena} ilość:{iloscNaMagazynie}";
            }
        }
        static void Main(string[] args)
        {
            Produkt p1 = new Produkt("Kiełbasa",6,7);
            Console.WriteLine(p1);
            

        }
    }
}