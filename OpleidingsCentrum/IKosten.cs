using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpleidingsCentrum
{
    interface IKosten
    {
        decimal Maandkost
        {
            get;
        }
        void GegevensTonen();
    }
}
