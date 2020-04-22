using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knihovna
{
    public partial class RemoveItemForm : Form
    {
        // Klasifikace objektů:
        //            0 -> Ctenar
        //            1 -> Kniha
        //            2 -> Vypujcka
        private const byte klasifikace_ctenar = 0;
        private const byte klasifikace_kniha = 1;
        private const byte klasifikace_vypujcka = 2;

        private byte Klasifikace { get; set; }
                

        public RemoveItemForm(byte klasifikace)
        {
            InitializeComponent();

            Klasifikace = klasifikace;

            // Uprava nadpisu dialogu
            switch (Klasifikace)
            {
                case klasifikace_ctenar:
                    Text = "Odebrat čtenáře";
                    break;
                case klasifikace_kniha:
                    Text = "Odebrat knihu";
                    break;
                default:
                    MessageBox.Show("Neznámý objekt");
                    this.Close(); // vyhodi se chyba -> nevadi na tohle musi přijít programátor
                    break;
            }
            this.textBox_ID.TextChanged += new System.EventHandler(this.KontrolaNaVstupu);

            button_OK.Enabled = false;
        }

        private void KontrolaNaVstupu(object sender, EventArgs e)
        {
            // kontrola zadaného řetězce, zda nám nerozbije CSV soubor
            if (textBox_ID.Text.Trim().Contains(";") ||
                textBox_ID.Text.Trim() == "")
            {
                button_OK.Enabled = false;
            }
            else
            {
                button_OK.Enabled = true;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)Application.OpenForms["Form1"];

            f1.databaze.Odeber(textBox_ID.Text, Klasifikace);           

            Close();
        }
    }
}
