using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    public class Ctenar
    {
        // Vlastnosti třídy
        public string Jmeno { get; private set; }
        public string Id { get; private set; }
        
        // Konstruktor
        public Ctenar(string jmeno, string id)
        {
            Jmeno = jmeno;
            Id = id;
        }
    }
}
