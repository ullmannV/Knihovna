using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    public class Vypujcka
    {
        // Vlastnosti třídy
        public Ctenar Drzitel { get; private set; }
        public Kniha Knizka { get; private set; }
        public string DatumPujceni { get; private set; }
        public string DatumVraceni { get; set; }
        public bool Vraceno { get; set; }
        public Vypujcka(Ctenar ctenar, Kniha kniha, string datum_pujceni, string datum_vraceni, bool vraceno = false)
        {
            Drzitel = ctenar;
            Knizka = kniha;
            Vraceno = vraceno;

            DatumPujceni = datum_pujceni;
            DatumVraceni = datum_vraceni;           
        }
    }
}
