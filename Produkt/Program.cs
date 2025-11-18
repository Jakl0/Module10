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
                    else
                    {
                        nazwa = value;
                    }
                }
            }
            public Produkt(string naz , int cena , int ilosc)
            {
                if (string.IsNullOrEmpty(naz))
                {
                    throw new ArgumentException("Nazwa nie może być pusta");
                }
                else
                {
                    this.nazwa = naz;
                }
                if (cena < 0)
                {
                    throw new ArgumentException("Cena nie może być ujemna");
                }
                else
                {
                    this.cena = cena;
                }

                if (ilosc < 0)
                {
                    throw new ArgumentException("Ilość nie może być ujemna");
                }
                else
                {
                    this.iloscNaMagazynie = ilosc;
                }
                
            }
            public override string ToString()
            {
                return $"nazwa:{nazwa} cena:{cena} ilość:{iloscNaMagazynie}";
            }
        }
        static void Main(string[] args)
        {
            Produkt p1 = new Produkt("",6,7);
            Console.WriteLine(p1);
            

        }
    }
}