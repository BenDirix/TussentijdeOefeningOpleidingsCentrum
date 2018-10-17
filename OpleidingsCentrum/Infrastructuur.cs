using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingsCentrum
{
    class Infrastructuur : IKosten
    {
        public decimal Huurprijs { get; set; }
        public string Naam { get; set; }
        public decimal Maandkost
        {
            get
            {
                return Huurprijs;
            }
        }

        public void GegevensTonen()
        {
            Console.WriteLine($"Gebouw Naam: {Naam}");
            Console.WriteLine($"Huurprijs: {Huurprijs} Euro per maand");
        }
    }
}
