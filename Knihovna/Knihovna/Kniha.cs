using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    public class Kniha
    {
        // Vlastnosti třídy
        public string Jmeno { get; private set; }
        public string Id { get; private set; }

        public bool Dostupna { get; private set; }

        // Konstruktor
        public Kniha(string jmeno, string id, bool dostupnost = true)
        {
            Jmeno = jmeno;
            Id = id;
            Dostupna = dostupnost;
        }

        public void Pujc()
        {
            Dostupna = false;
        }

        public void Vrat()
        {
            Dostupna = true;
        }
    }
}
