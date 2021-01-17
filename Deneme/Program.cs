using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel();
            personel1.PersonelAdi = "Ezgi";
            personel1.PersonelSoyadi = "Kütük";
            personel1.PersonelNo = 107;

            Personel personel2 = new Personel();
            personel2.PersonelAdi = "Mehmet";
            personel2.PersonelSoyadi = "Cengiz";
            personel2.PersonelNo = 100;

            Personel[] personeller = new Personel[] { personel1, personel2 };

            foreach (var personel in personeller)
            {
                Console.WriteLine(personel.PersonelAdi + " " + personel.PersonelSoyadi + " " + personel.PersonelNo);
            }
            Console.ReadLine();
        }
    }

    class Personel
    {
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public int PersonelNo { get; set; }

    }
}
