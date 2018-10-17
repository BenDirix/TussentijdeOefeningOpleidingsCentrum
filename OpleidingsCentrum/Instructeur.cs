using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OpleidingsCentrum
{
    enum Vakgebieden
    {
        Ontwikkeling, Netwerken
    }
    class Instructeur : Personeelslid
    {
        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public Instructeur(int personeelsnummer, string familienaam, string voornaam, decimal brutomaandloon, Vakgebieden vakgebied, string email) :base(personeelsnummer, familienaam, voornaam, brutomaandloon)
        {
            Vakgebied = vakgebied;
            Email = email;
        }

        public Vakgebieden Vakgebied { get; set; }

        private string emailValue;
        public string Email
        {
            get
            {
                return emailValue;
            }
            set
            {
                if (!emailRegex.IsMatch(value))
                    throw new OngeldigEmailadresException("Ongeldig Email adres bij het aanmaken van instructeur!", value);
                emailValue = value;
            }
        }

        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine($"Vakgebied: {Vakgebied}");
            Console.WriteLine($"Email: {Email}");
        }
        

        public class OngeldigEmailadresException : Exception
        {
            public string VerkeerdeEmail { get; set; }
            public OngeldigEmailadresException(string message, string email) : base(message)
            {
                VerkeerdeEmail = email;
            }
        }

        
    }
}
