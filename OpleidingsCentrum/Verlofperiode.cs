using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingsCentrum
{
    class Verlofperiode
    {
        public string Naam { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        
        public override string ToString()
        {
            return $"{Naam}:\nVan: {BeginDatum:dd MMMM yyyy}\nTot: {EindDatum:dd MMMM yyyy}";
        }
        
    }
}
