using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingsCentrum
{
    class Medewerker:Personeelslid
    {
        public Medewerker(int personeelsnummer, string familienaam, string voornaam, decimal brutomaandloon, int aantalcursisten) :base(personeelsnummer,familienaam,voornaam,brutomaandloon)
        {
            AantalCursisten = aantalcursisten;
        }
        public int AantalCursisten { get; set; }

        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine($"Aantal Cursisten: {AantalCursisten}");
        }
    }
}
