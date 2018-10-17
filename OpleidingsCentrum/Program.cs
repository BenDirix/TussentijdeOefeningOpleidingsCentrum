using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OpleidingsCentrum
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                var zomervakantie = new Verlofperiode
                {
                    Naam = "Zomervakantie",
                    BeginDatum = new DateTime(DateTime.Now.Year, 7, 1),
                    EindDatum = new DateTime(DateTime.Now.Year, 7, 31)
                };
                var kerstvakantie = new Verlofperiode
                {
                    Naam = "Kerstvakantie",
                    BeginDatum = new DateTime(DateTime.Now.Year, 12, 25),
                    EindDatum = new DateTime(DateTime.Now.Year + 1, 1, 1)
                };

                IKosten[] opleidingscentrum = new IKosten[]
                {
                new Instructeur(1, "Doe", "John", 2342m, Vakgebieden.Netwerken, "JohnDoe@opleidingscentrum.be"),
                new Instructeur(2,"Bublitz", "Vivian", 2500m, Vakgebieden.Ontwikkeling, "Vivianbublitz@opleidingscentrum.be"),
                new Medewerker(3, "Tutor", "David", 2367m, 10),
                new Infrastructuur{Naam = "Opleidingscentrum1", Huurprijs=1500m},
                new Infrastructuur{Naam = "Opleidingscentrum2", Huurprijs=2500m}
                };

                if (Personeelslid.Verlofperiode == null)
                    Personeelslid.Verlofperiode = new List<Verlofperiode>();

                Personeelslid.Verlofperiode.Add(kerstvakantie);
                Personeelslid.Verlofperiode.Add(zomervakantie);

                decimal totaal = 0;
                foreach (var item in opleidingscentrum)
                {
                    item.GegevensTonen();
                    Console.WriteLine();
                    totaal += item.Maandkost;
                }
                Console.WriteLine($"Totale kost: {totaal} Eur");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }  
    }
}
