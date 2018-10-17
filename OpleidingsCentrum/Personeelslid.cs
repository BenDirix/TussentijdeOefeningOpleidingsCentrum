using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingsCentrum
{
    class Personeelslid : IKosten
    {
        public int Personeelsnummer { get; private set; }
        public string FamilieNaam { get; set; }
        public string VoorNaam { get; set; }
        public decimal BrutoMaandloon { get; set; }
        public Personeelslid(int personeelsnummer, string familienaam, string voornaam, decimal brutomaandloon)
        {
            Personeelsnummer = personeelsnummer;
            FamilieNaam = familienaam;
            VoorNaam = voornaam;
            BrutoMaandloon = brutomaandloon;
        }
        public static List<Verlofperiode> Verlofperiode { get; set; }

        public decimal Maandkost
        {
            get
            {
                return BrutoMaandloon * 0.60m;
            }
        }

        public virtual void GegevensTonen()
        {
            Console.WriteLine($"Personeelsnummer: {Personeelsnummer}");
            Console.WriteLine($"Voornaam: {VoorNaam}");
            Console.WriteLine($"Familienaam: {FamilieNaam}");
            Console.WriteLine($"Bruto Maandloon: {BrutoMaandloon} Euro per maand");
        }
    }
}
