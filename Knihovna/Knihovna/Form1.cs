using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knihovna
{
    public partial class Form1 : Form
    {
        // Klasifikace objektů:
        //            0 -> Ctenar
        //            1 -> Kniha
        //            2 -> Vypujcka   
        private const byte klasifikace_ctenar = 0;
        private const byte klasifikace_kniha = 1;
        private const byte klasifikace_vypujcka = 2;

        public Databaze databaze;
        public Form1()
        {
            // Inicializace formuláře
            InitializeComponent();
            button_pujcit.Enabled = false;
            button_vratit.Enabled = false;

            // Vytvoreni databaze programu
            databaze = new Databaze("databaze.csv");

            databaze.CtenarPridan += AddListBoxCtenari;
            databaze.KnihaPridana += AddListBoxKnihy;

            databaze.CtenarOdebran += RemoveListBoxCtenari;
            databaze.KnihaOdebrana += RemoveListBoxKnihy;

            databaze.VypujckaPridana += RedrawTlacitek;            
            databaze.VypujckaOdebrana += RedrawTlacitek;

            databaze.Load(); // Načtení dat z databáze (povinné)
        }

        private void přidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm form2 = new AddItemForm(klasifikace_kniha);
            form2.ShowDialog();
        }

        private void přidatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddItemForm form2 = new AddItemForm(klasifikace_ctenar);
            form2.ShowDialog();
        }

        private void AddListBoxCtenari(object sender, Ctenar ctenar)
        {
            listbox_ctenari.Items.Add("[" + ctenar.Id + "]" + " " + ctenar.Jmeno);
        }

        private void AddListBoxKnihy(object sender, Kniha kniha)
        {
            listbox_knihy.Items.Add("[" + kniha.Id + "]" + " " + kniha.Jmeno);
        }

        private void odebratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listbox_knihy.ClearSelected();
            RemoveItemForm form2 = new RemoveItemForm(klasifikace_kniha);
            form2.ShowDialog();
        }

        private void odebratToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listbox_ctenari.ClearSelected();
            RemoveItemForm form2 = new RemoveItemForm(klasifikace_ctenar);
            form2.ShowDialog();
        }
        private void RemoveListBoxCtenari(object sender, int index)
        {            
            listbox_ctenari.Items.RemoveAt(index);
        }
        private void RemoveListBoxKnihy(object sender, int index)
        {
           
            listbox_knihy.Items.RemoveAt(index);
        }

        private void button_pujcit_Click(object sender, EventArgs e)
        {
            databaze.Knihy[listbox_knihy.SelectedIndex].Pujc();
            databaze.Pridej(new Vypujcka(databaze.Ctenari[listbox_ctenari.SelectedIndex], databaze.Knihy[listbox_knihy.SelectedIndex], DateTime.Today.ToShortDateString(), DateTime.Today.AddMonths(1).ToShortDateString()));
            lbl_kniha_dostupna.Text = "NE";            
        }

        private void button_vratit_Click(object sender, EventArgs e)
        {
            databaze.OdeberVypujcku(databaze.Ctenari[listbox_ctenari.SelectedIndex], databaze.Knihy[listbox_knihy.SelectedIndex]);
            lbl_kniha_dostupna.Text = "ANO";
        }

        private void listbox_ctenari_SelectedIndexChanged(object sender, EventArgs e)
        {
            // vypis informaci vybranych objektu 
            try
            {
                txB_ctenar_jmeno.Text = databaze.Ctenari[listbox_ctenari.SelectedIndex].Jmeno;
                txB_ctenar_ID.Text = databaze.Ctenari[listbox_ctenari.SelectedIndex].Id;
            }
            catch (Exception exception) 
            {
                txB_ctenar_jmeno.Text = "";
                txB_ctenar_ID.Text = "";
            }
            finally
            {
                // Osetreni tlacitka pujcit   
                PovoleniTlacitkaPujcit();
                // Osetreni tlacitka vratit
                PovoleniTlacitkaVratit();
            }            
        }

        private void listbox_knihy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // vypis informaci vybranych objektu         
            try
            {
                txB_kniha_jmeno.Text = databaze.Knihy[listbox_knihy.SelectedIndex].Jmeno;
                txB_kniha_ID.Text = databaze.Knihy[listbox_knihy.SelectedIndex].Id;

                if (databaze.Knihy[listbox_knihy.SelectedIndex].Dostupna) lbl_kniha_dostupna.Text = "ANO";
                else lbl_kniha_dostupna.Text = "NE";
            }
            catch (Exception exception)
            {
                txB_kniha_jmeno.Text = "";
                txB_kniha_ID.Text = "";

                lbl_kniha_dostupna.Text = "- - -";
            }
            finally
            {
                // Osetreni tlacitka pujcit   
                PovoleniTlacitkaPujcit();
                // Osetreni tlacitka vratit
                PovoleniTlacitkaVratit();
            }                                 
        }
        private void PovoleniTlacitkaPujcit()
        {
            if (listbox_ctenari.SelectedIndex >= 0 && listbox_knihy.SelectedIndex >= 0)
            {
                if (databaze.Knihy[listbox_knihy.SelectedIndex].Dostupna)
                {
                    button_pujcit.Enabled = true;
                }
                else
                {
                    button_pujcit.Enabled = false;
                }
            }
            else
            {
                button_pujcit.Enabled = false;
            }
        }
        private void PovoleniTlacitkaVratit()
        {
            if (listbox_ctenari.SelectedIndex >= 0 && listbox_knihy.SelectedIndex >= 0)
            {

                foreach (Vypujcka v in databaze.Vypujcky)
                {
                    if (v.Drzitel.Id == databaze.Ctenari[listbox_ctenari.SelectedIndex].Id &&
                        v.Knizka.Id == databaze.Knihy[listbox_knihy.SelectedIndex].Id &&
                        v.Vraceno == false)
                    {
                        button_vratit.Enabled = true;
                        break;
                    }
                    else
                    {
                        button_vratit.Enabled = false;
                    }
                }
            }
            else
            {
                button_vratit.Enabled = false;
            }
        }
        private void RedrawTlacitek(object sender, Vypujcka e)
        {
            PovoleniTlacitkaPujcit();
            PovoleniTlacitkaVratit();
        }

        private void RedrawTlacitek(object sender, int e)
        {
            PovoleniTlacitkaPujcit();
            PovoleniTlacitkaVratit();
        }

        private void txB_ctenari_hledat_TextChanged(object sender, EventArgs e)
        {
            foreach (Ctenar c in databaze.Ctenari)
            {
                if (c.Id == txB_ctenari_hledat.Text)
                {
                    listbox_ctenari.SelectedIndex = databaze.Ctenari.IndexOf(c);
                    txB_ctenari_hledat.Text = "";
                }
            }           
        }

        private void txB_knihy_hledat_TextChanged(object sender, EventArgs e)
        {
            foreach (Kniha k in databaze.Knihy)
            {
                if (k.Id == txB_knihy_hledat.Text)
                {
                    listbox_knihy.SelectedIndex = databaze.Knihy.IndexOf(k);
                    txB_knihy_hledat.Text = "";
                }
            }            
        }
        // tisk přehledu půjčených knih
        private void půjčenéKnihyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("seznam_pujcene.txt");

            writer.WriteLine("### Pujcene knihy ###");

            foreach (Kniha k in databaze.Knihy)
            {
                // zjisti zda je kniha pujcena
                if (!k.Dostupna)
                    writer.WriteLine(k.Id + " " + k.Jmeno);
            }

            writer.Flush();
            writer.Close();

            MessageBox.Show("Tisk dokončen");
        }
        // tisk přehledu pohybů podle čtenářů
        private void podleČtenářůToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("prehled_dle_ctenaru.txt");

            writer.WriteLine("### Přehled dle čtenářů ###");
                        
            foreach (Ctenar c in databaze.Ctenari)
            {
                writer.WriteLine(c.Id + " " + c.Jmeno);

                foreach (Vypujcka v in databaze.Vypujcky)
                {
                    if (v.Drzitel.Id == c.Id)
                    {
                        if (v.Vraceno)
                        {
                            writer.WriteLine("|\\");
                            writer.WriteLine("| " + v.DatumPujceni + " >> " + v.Knizka.Id + " " + v.Knizka.Jmeno);
                            writer.WriteLine("|\\");
                            writer.WriteLine("| " + v.DatumVraceni + " << " + v.Knizka.Id + " " + v.Knizka.Jmeno);
                        }
                        else
                        {
                            writer.WriteLine("|\\");
                            writer.WriteLine("| " + v.DatumPujceni + " >> " + v.Knizka.Id + " " + v.Knizka.Jmeno);
                        }
                    }
                }
            }

            writer.Flush();
            writer.Close();

            MessageBox.Show("Tisk dokončen");
        }
        // tisk přehledu pohybů podle knih
        private void podleKnihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("prehled_dle_knih.txt");

            writer.WriteLine("### Přehled dle knih ###");

            foreach (Kniha k in databaze.Knihy)
            {
                writer.WriteLine(k.Id + " " + k.Jmeno);

                foreach (Vypujcka v in databaze.Vypujcky)
                {
                    if (v.Knizka.Id == k.Id)
                    {
                        if (v.Vraceno)
                        {
                            writer.WriteLine("|\\");
                            writer.WriteLine("| " + v.DatumPujceni + " >> " + v.Drzitel.Id + " " + v.Drzitel.Jmeno);
                            writer.WriteLine("|\\");
                            writer.WriteLine("| " + v.DatumVraceni + " << " + v.Drzitel.Id + " " + v.Drzitel.Jmeno);
                        }
                        else
                        {
                            writer.WriteLine("|\\");
                            writer.WriteLine("| " + v.DatumPujceni + " >> " + v.Drzitel.Id + " " + v.Drzitel.Jmeno);
                        }
                    }
                }
            }

            writer.Flush();
            writer.Close();

            MessageBox.Show("Tisk dokončen");
        }
    }
}
