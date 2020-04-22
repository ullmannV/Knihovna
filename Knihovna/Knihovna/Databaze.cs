using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knihovna
{
    
    public class Databaze
    {
        // Klasifikace objektů:
        //            0 -> Ctenar
        //            1 -> Kniha
        //            2 -> Vypujcka
        private const byte klasifikace_ctenar = 0;
        private const byte klasifikace_kniha = 1;
        private const byte klasifikace_vypujcka = 2;

        // Události
        public event EventHandler<Ctenar> CtenarPridan;
        public event EventHandler<Kniha> KnihaPridana;
        public event EventHandler<Vypujcka> VypujckaPridana;
        public event EventHandler<int> CtenarOdebran;
        public event EventHandler<int> KnihaOdebrana;
        public event EventHandler<int> VypujckaOdebrana;

        // Vlastnosti Databaze
        public string Soubor { get; private set; }   
        public List<Ctenar> Ctenari { get; private set; }
        public List<Kniha> Knihy { get; private set; }
        public List<Vypujcka> Vypujcky { get; private set; }

        // Konstruktor
        public Databaze(string soubor)
        {
            Soubor = soubor;

            Ctenari = new List<Ctenar>();
            Knihy = new List<Kniha>();
            Vypujcky = new List<Vypujcka>();                    
        }

        // Metody

        public void Load()
        {
            try
            {
                // Nahraj data z databaze
                StreamReader reader = new StreamReader(Soubor);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] splitted = line.Split(';');
                    // roztrid data do seznamu (List<Datatype>)
                    switch (int.Parse(splitted[0]))
                    {
                        // Pořadí dat:
                        //  INDEX | VÝZNAM
                        //    1   |   id   / id drzitele
                        //    2   |  jméno / id knizky
                        // (  3   | dostupnost, vrácení )
                        // (  4   | datum pujceni )
                        // (  5   | datum vraceni )
                        case klasifikace_ctenar:
                            Pridej(new Ctenar(splitted[2], splitted[1]));
                            break;
                        case klasifikace_kniha:
                            Pridej(new Kniha(splitted[2], splitted[1], bool.Parse(splitted[3])));
                            break;
                        case klasifikace_vypujcka:
                            foreach (Ctenar c in Ctenari)
                            {
                                if (c.Id == splitted[1])
                                {
                                    foreach (Kniha k in Knihy)
                                    {
                                        if (k.Id == splitted[2])
                                        {
                                            Pridej(new Vypujcka(c, k, splitted[4], splitted[5], bool.Parse(splitted[3])));
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                    }
                }

                reader.Close(); // ukonči tok dat
            }
            catch (System.IO.FileNotFoundException e)
            {
                // toto nastane při prvním spuštění, pokud neexistuje žádná databáze, není proč se strachovat
            }
            finally
            {
                // Povol zápis do CSV souboru až po načtení
                KnihaPridana += UpdateCSVevent;
                CtenarPridan += UpdateCSVevent;
                VypujckaPridana += UpdateCSVevent;
                KnihaOdebrana += UpdateCSVevent;
                CtenarOdebran += UpdateCSVevent;
                VypujckaOdebrana += UpdateCSVevent;
            }            
        }


        // Čtenář
        public void Pridej(Ctenar ctenar)
        {
            // Dostupnost zadaneho ID
            foreach (Ctenar c in Ctenari)
            {
                if (c.Id == ctenar.Id)
                {
                    MessageBox.Show("ID obsazeno");
                    return; // zamez duplikátním ID
                }
            }

            foreach (Kniha k in Knihy)
            {
                if (k.Id == ctenar.Id)
                {
                    MessageBox.Show("ID obsazeno");
                    return; // zamez duplikátním ID
                }
            }

            // Pridani ctenare
            Ctenari.Add(ctenar);
            
            CtenarPridan?.Invoke(this, ctenar);
        }

        // Knihy
        public void Pridej(Kniha kniha)
        {
            // Dostupnost zadaneho ID
            foreach (Kniha k in Knihy)
            {
                if (k.Id == kniha.Id)
                {
                    MessageBox.Show("ID obsazeno");
                    return; // zamez duplikátním ID
                }
            }

            foreach (Ctenar c in Ctenari)
            {
                if (c.Id == kniha.Id)
                {
                    MessageBox.Show("ID obsazeno");
                    return; // zamez duplikátním ID
                }
            }

            // Pridani knihy
            Knihy.Add(kniha);
            
            KnihaPridana?.Invoke(this, kniha);
        }

        // Výpůjčky
        public void Pridej(Vypujcka vypujcka)
        {
            Vypujcky.Add(vypujcka);

            VypujckaPridana?.Invoke(this, vypujcka);
        }

        public void Odeber(string id, byte klasifikace)
        {
            switch(klasifikace)
            {
                case klasifikace_ctenar:
                    foreach (Ctenar c in Ctenari)
                    {
                        if (c.Id == id) 
                        {
                            int index;
                            // Zkontroluj zda čtenář nemá půjčenou knihu
                            foreach (Vypujcka v in Vypujcky)
                            {
                                if (v.Drzitel.Id == c.Id && v.Vraceno == false)
                                {
                                    MessageBox.Show("Uživatele nelze odebrat! Stále nevrátil všechny knihy!");
                                    return;
                                }
                            }

                            index = Ctenari.IndexOf(c);
                            
                            Ctenari.RemoveAt(index);
                            
                            CtenarOdebran?.Invoke(this, index);
                            
                            return;
                        }
                    }
                    MessageBox.Show("Tento čtenář neexistuje");
                    break;
                case klasifikace_kniha:
                    foreach (Kniha k in Knihy)
                    {
                        if (k.Id == id)
                        {
                            int index;
                            // Zkontroluj zda knihu lze řádně zlikvidovat
                            foreach (Vypujcka v in Vypujcky)
                            {
                                if (v.Knizka.Id == k.Id && v.Vraceno == false)
                                {
                                    MessageBox.Show("Nemůžeme odepsat knihu, kterou nemáme u sebe!");
                                    return;
                                }
                            }

                            index = Knihy.IndexOf(k);
                            
                            Knihy.RemoveAt(index);
                            
                            KnihaOdebrana?.Invoke(this, index);
                            
                            return;
                        }
                    }
                    MessageBox.Show("Tato kniha neexistuje");
                    break;                
            }
        }

        public void OdeberVypujcku(Ctenar c, Kniha k)
        {
            foreach (Vypujcka v in Vypujcky)
            {
                if (c.Id == v.Drzitel.Id && k.Id == v.Knizka.Id && v.Vraceno == false)
                {
                    int index = Vypujcky.IndexOf(v);

                    // zkontroluj zda ctenar nevratil knihu pozde
                    if (DateTime.Compare(DateTime.Parse(v.DatumVraceni), DateTime.Today) < 0)
                    {
                        MessageBox.Show("Kniha je vrácena pozdě!");
                    }

                    // Oznac vypujcku za vyresenou
                    Vypujcky[index].Vraceno = true;
                    Vypujcky[index].DatumVraceni = DateTime.Today.ToShortDateString();

                    // Oznac knihu jako vracenou
                    index = Knihy.IndexOf(k);

                    Knihy[index].Vrat();

                    VypujckaOdebrana?.Invoke(this, index);

                    break; // cyklus by již nic nenašel                    
                } 
            }
        }        
        
        private void UpdateCSVevent(object sender, Ctenar e)
        {
            UpdateCSV();         
        }
        private void UpdateCSVevent(object sender, Kniha e)
        {
            UpdateCSV();
        }
        private void UpdateCSVevent(object sender, Vypujcka e)
        {
            UpdateCSV();
        }
        private void UpdateCSVevent(object sender, int e)
        {
            UpdateCSV();
        }

        private void UpdateCSV()
        {
            StreamWriter sw = new StreamWriter(Soubor);

            foreach (Ctenar c in Ctenari)
            {
                string[] temp_line = new string[] { klasifikace_ctenar.ToString(), c.Id, c.Jmeno};
                sw.WriteLine(String.Join(";", temp_line));
            }

            foreach (Kniha k in Knihy)
            {
                string[] temp_line = new string[] { klasifikace_kniha.ToString(), k.Id, k.Jmeno, k.Dostupna.ToString() };
                sw.WriteLine(String.Join(";", temp_line));
            }

            foreach (Vypujcka v in Vypujcky)
            {
                string[] temp_line = new string[] { klasifikace_vypujcka.ToString(), v.Drzitel.Id, v.Knizka.Id, v.Vraceno.ToString(), v.DatumPujceni, v.DatumVraceni };
                sw.WriteLine(String.Join(";", temp_line));
            }

            sw.Flush();

            sw.Close();
        }
    }
}
