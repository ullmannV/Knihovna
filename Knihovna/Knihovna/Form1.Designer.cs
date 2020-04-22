namespace Knihovna
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.knihyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odebratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uživateléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odebratToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.půjčenéKnihyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přehledČtenářůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_ctenari = new System.Windows.Forms.GroupBox();
            this.listbox_ctenari = new System.Windows.Forms.ListBox();
            this.gb_knihy = new System.Windows.Forms.GroupBox();
            this.listbox_knihy = new System.Windows.Forms.ListBox();
            this.gB_ctenar = new System.Windows.Forms.GroupBox();
            this.txB_ctenar_ID = new System.Windows.Forms.TextBox();
            this.txB_ctenar_jmeno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gB_kniha = new System.Windows.Forms.GroupBox();
            this.lbl_kniha_dostupna = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txB_kniha_ID = new System.Windows.Forms.TextBox();
            this.txB_kniha_jmeno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_pujcit = new System.Windows.Forms.Button();
            this.button_vratit = new System.Windows.Forms.Button();
            this.txB_ctenari_hledat = new System.Windows.Forms.TextBox();
            this.txB_knihy_hledat = new System.Windows.Forms.TextBox();
            this.podleČtenářůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podleKnihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gb_ctenari.SuspendLayout();
            this.gb_knihy.SuspendLayout();
            this.gB_ctenar.SuspendLayout();
            this.gB_kniha.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knihyToolStripMenuItem,
            this.uživateléToolStripMenuItem,
            this.tiskToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // knihyToolStripMenuItem
            // 
            this.knihyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatToolStripMenuItem,
            this.odebratToolStripMenuItem});
            this.knihyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.knihyToolStripMenuItem.Name = "knihyToolStripMenuItem";
            this.knihyToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.knihyToolStripMenuItem.Text = "Knihy";
            // 
            // přidatToolStripMenuItem
            // 
            this.přidatToolStripMenuItem.Name = "přidatToolStripMenuItem";
            this.přidatToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.přidatToolStripMenuItem.Text = "Přidat";
            this.přidatToolStripMenuItem.Click += new System.EventHandler(this.přidatToolStripMenuItem_Click);
            // 
            // odebratToolStripMenuItem
            // 
            this.odebratToolStripMenuItem.Name = "odebratToolStripMenuItem";
            this.odebratToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.odebratToolStripMenuItem.Text = "Odebrat";
            this.odebratToolStripMenuItem.Click += new System.EventHandler(this.odebratToolStripMenuItem_Click);
            // 
            // uživateléToolStripMenuItem
            // 
            this.uživateléToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatToolStripMenuItem1,
            this.odebratToolStripMenuItem1});
            this.uživateléToolStripMenuItem.Name = "uživateléToolStripMenuItem";
            this.uživateléToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.uživateléToolStripMenuItem.Text = "Čtenáři";
            // 
            // přidatToolStripMenuItem1
            // 
            this.přidatToolStripMenuItem1.Name = "přidatToolStripMenuItem1";
            this.přidatToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.přidatToolStripMenuItem1.Text = "Přidat";
            this.přidatToolStripMenuItem1.Click += new System.EventHandler(this.přidatToolStripMenuItem1_Click);
            // 
            // odebratToolStripMenuItem1
            // 
            this.odebratToolStripMenuItem1.Name = "odebratToolStripMenuItem1";
            this.odebratToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.odebratToolStripMenuItem1.Text = "Odebrat";
            this.odebratToolStripMenuItem1.Click += new System.EventHandler(this.odebratToolStripMenuItem1_Click);
            // 
            // tiskToolStripMenuItem
            // 
            this.tiskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.půjčenéKnihyToolStripMenuItem,
            this.přehledČtenářůToolStripMenuItem});
            this.tiskToolStripMenuItem.Name = "tiskToolStripMenuItem";
            this.tiskToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.tiskToolStripMenuItem.Text = "Tisk";
            // 
            // půjčenéKnihyToolStripMenuItem
            // 
            this.půjčenéKnihyToolStripMenuItem.Name = "půjčenéKnihyToolStripMenuItem";
            this.půjčenéKnihyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.půjčenéKnihyToolStripMenuItem.Text = "Půjčené knihy";
            this.půjčenéKnihyToolStripMenuItem.Click += new System.EventHandler(this.půjčenéKnihyToolStripMenuItem_Click);
            // 
            // přehledČtenářůToolStripMenuItem
            // 
            this.přehledČtenářůToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podleČtenářůToolStripMenuItem,
            this.podleKnihToolStripMenuItem});
            this.přehledČtenářůToolStripMenuItem.Name = "přehledČtenářůToolStripMenuItem";
            this.přehledČtenářůToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.přehledČtenářůToolStripMenuItem.Text = "Přehled pohybů";
            // 
            // gb_ctenari
            // 
            this.gb_ctenari.Controls.Add(this.listbox_ctenari);
            this.gb_ctenari.Location = new System.Drawing.Point(10, 51);
            this.gb_ctenari.Name = "gb_ctenari";
            this.gb_ctenari.Size = new System.Drawing.Size(215, 485);
            this.gb_ctenari.TabIndex = 1;
            this.gb_ctenari.TabStop = false;
            this.gb_ctenari.Text = "Čtenáři";
            // 
            // listbox_ctenari
            // 
            this.listbox_ctenari.FormattingEnabled = true;
            this.listbox_ctenari.Location = new System.Drawing.Point(6, 19);
            this.listbox_ctenari.Name = "listbox_ctenari";
            this.listbox_ctenari.Size = new System.Drawing.Size(203, 459);
            this.listbox_ctenari.TabIndex = 0;
            this.listbox_ctenari.SelectedIndexChanged += new System.EventHandler(this.listbox_ctenari_SelectedIndexChanged);
            // 
            // gb_knihy
            // 
            this.gb_knihy.Controls.Add(this.listbox_knihy);
            this.gb_knihy.Location = new System.Drawing.Point(250, 51);
            this.gb_knihy.Name = "gb_knihy";
            this.gb_knihy.Size = new System.Drawing.Size(300, 485);
            this.gb_knihy.TabIndex = 2;
            this.gb_knihy.TabStop = false;
            this.gb_knihy.Text = "Knihy";
            // 
            // listbox_knihy
            // 
            this.listbox_knihy.FormattingEnabled = true;
            this.listbox_knihy.Location = new System.Drawing.Point(6, 19);
            this.listbox_knihy.Name = "listbox_knihy";
            this.listbox_knihy.Size = new System.Drawing.Size(288, 459);
            this.listbox_knihy.TabIndex = 1;
            this.listbox_knihy.SelectedIndexChanged += new System.EventHandler(this.listbox_knihy_SelectedIndexChanged);
            // 
            // gB_ctenar
            // 
            this.gB_ctenar.BackColor = System.Drawing.Color.YellowGreen;
            this.gB_ctenar.Controls.Add(this.txB_ctenar_ID);
            this.gB_ctenar.Controls.Add(this.txB_ctenar_jmeno);
            this.gB_ctenar.Controls.Add(this.label2);
            this.gB_ctenar.Controls.Add(this.label1);
            this.gB_ctenar.Location = new System.Drawing.Point(568, 51);
            this.gB_ctenar.Name = "gB_ctenar";
            this.gB_ctenar.Size = new System.Drawing.Size(279, 137);
            this.gB_ctenar.TabIndex = 3;
            this.gB_ctenar.TabStop = false;
            this.gB_ctenar.Text = "Čtenář";
            // 
            // txB_ctenar_ID
            // 
            this.txB_ctenar_ID.Location = new System.Drawing.Point(44, 42);
            this.txB_ctenar_ID.Name = "txB_ctenar_ID";
            this.txB_ctenar_ID.ReadOnly = true;
            this.txB_ctenar_ID.Size = new System.Drawing.Size(229, 20);
            this.txB_ctenar_ID.TabIndex = 3;
            // 
            // txB_ctenar_jmeno
            // 
            this.txB_ctenar_jmeno.Location = new System.Drawing.Point(44, 16);
            this.txB_ctenar_jmeno.Name = "txB_ctenar_jmeno";
            this.txB_ctenar_jmeno.ReadOnly = true;
            this.txB_ctenar_jmeno.Size = new System.Drawing.Size(229, 20);
            this.txB_ctenar_jmeno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // gB_kniha
            // 
            this.gB_kniha.BackColor = System.Drawing.Color.YellowGreen;
            this.gB_kniha.Controls.Add(this.lbl_kniha_dostupna);
            this.gB_kniha.Controls.Add(this.label5);
            this.gB_kniha.Controls.Add(this.txB_kniha_ID);
            this.gB_kniha.Controls.Add(this.txB_kniha_jmeno);
            this.gB_kniha.Controls.Add(this.label4);
            this.gB_kniha.Controls.Add(this.label3);
            this.gB_kniha.Location = new System.Drawing.Point(568, 205);
            this.gB_kniha.Name = "gB_kniha";
            this.gB_kniha.Size = new System.Drawing.Size(279, 137);
            this.gB_kniha.TabIndex = 4;
            this.gB_kniha.TabStop = false;
            this.gB_kniha.Text = "Kniha";
            // 
            // lbl_kniha_dostupna
            // 
            this.lbl_kniha_dostupna.AutoSize = true;
            this.lbl_kniha_dostupna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_kniha_dostupna.Location = new System.Drawing.Point(128, 96);
            this.lbl_kniha_dostupna.Name = "lbl_kniha_dostupna";
            this.lbl_kniha_dostupna.Size = new System.Drawing.Size(36, 20);
            this.lbl_kniha_dostupna.TabIndex = 7;
            this.lbl_kniha_dostupna.Text = "- - - ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dostupna:";
            // 
            // txB_kniha_ID
            // 
            this.txB_kniha_ID.Location = new System.Drawing.Point(44, 49);
            this.txB_kniha_ID.Name = "txB_kniha_ID";
            this.txB_kniha_ID.ReadOnly = true;
            this.txB_kniha_ID.Size = new System.Drawing.Size(229, 20);
            this.txB_kniha_ID.TabIndex = 5;
            // 
            // txB_kniha_jmeno
            // 
            this.txB_kniha_jmeno.Location = new System.Drawing.Point(44, 22);
            this.txB_kniha_jmeno.Name = "txB_kniha_jmeno";
            this.txB_kniha_jmeno.ReadOnly = true;
            this.txB_kniha_jmeno.Size = new System.Drawing.Size(229, 20);
            this.txB_kniha_jmeno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jméno:";
            // 
            // button_pujcit
            // 
            this.button_pujcit.Location = new System.Drawing.Point(568, 359);
            this.button_pujcit.Name = "button_pujcit";
            this.button_pujcit.Size = new System.Drawing.Size(279, 79);
            this.button_pujcit.TabIndex = 5;
            this.button_pujcit.Text = "Provést výpůjčku";
            this.button_pujcit.UseVisualStyleBackColor = true;
            this.button_pujcit.Click += new System.EventHandler(this.button_pujcit_Click);
            // 
            // button_vratit
            // 
            this.button_vratit.Location = new System.Drawing.Point(568, 457);
            this.button_vratit.Name = "button_vratit";
            this.button_vratit.Size = new System.Drawing.Size(279, 79);
            this.button_vratit.TabIndex = 6;
            this.button_vratit.Text = "Vrátit";
            this.button_vratit.UseVisualStyleBackColor = true;
            this.button_vratit.Click += new System.EventHandler(this.button_vratit_Click);
            // 
            // txB_ctenari_hledat
            // 
            this.txB_ctenari_hledat.Location = new System.Drawing.Point(10, 535);
            this.txB_ctenari_hledat.Name = "txB_ctenari_hledat";
            this.txB_ctenari_hledat.Size = new System.Drawing.Size(215, 20);
            this.txB_ctenari_hledat.TabIndex = 7;
            this.txB_ctenari_hledat.TextChanged += new System.EventHandler(this.txB_ctenari_hledat_TextChanged);
            // 
            // txB_knihy_hledat
            // 
            this.txB_knihy_hledat.Location = new System.Drawing.Point(250, 535);
            this.txB_knihy_hledat.Name = "txB_knihy_hledat";
            this.txB_knihy_hledat.Size = new System.Drawing.Size(300, 20);
            this.txB_knihy_hledat.TabIndex = 8;
            this.txB_knihy_hledat.TextChanged += new System.EventHandler(this.txB_knihy_hledat_TextChanged);
            // 
            // podleČtenářůToolStripMenuItem
            // 
            this.podleČtenářůToolStripMenuItem.Name = "podleČtenářůToolStripMenuItem";
            this.podleČtenářůToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.podleČtenářůToolStripMenuItem.Text = "Podle čtenářů";
            this.podleČtenářůToolStripMenuItem.Click += new System.EventHandler(this.podleČtenářůToolStripMenuItem_Click);
            // 
            // podleKnihToolStripMenuItem
            // 
            this.podleKnihToolStripMenuItem.Name = "podleKnihToolStripMenuItem";
            this.podleKnihToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.podleKnihToolStripMenuItem.Text = "Podle knih";
            this.podleKnihToolStripMenuItem.Click += new System.EventHandler(this.podleKnihToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(859, 561);
            this.Controls.Add(this.txB_knihy_hledat);
            this.Controls.Add(this.txB_ctenari_hledat);
            this.Controls.Add(this.button_vratit);
            this.Controls.Add(this.button_pujcit);
            this.Controls.Add(this.gB_kniha);
            this.Controls.Add(this.gB_ctenar);
            this.Controls.Add(this.gb_knihy);
            this.Controls.Add(this.gb_ctenari);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Knihovna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_ctenari.ResumeLayout(false);
            this.gb_knihy.ResumeLayout(false);
            this.gB_ctenar.ResumeLayout(false);
            this.gB_ctenar.PerformLayout();
            this.gB_kniha.ResumeLayout(false);
            this.gB_kniha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem knihyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odebratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uživateléToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odebratToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem půjčenéKnihyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přehledČtenářůToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_ctenari;
        private System.Windows.Forms.ListBox listbox_ctenari;
        private System.Windows.Forms.GroupBox gb_knihy;
        private System.Windows.Forms.ListBox listbox_knihy;
        private System.Windows.Forms.GroupBox gB_ctenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gB_kniha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_pujcit;
        private System.Windows.Forms.Button button_vratit;
        private System.Windows.Forms.TextBox txB_ctenar_ID;
        private System.Windows.Forms.TextBox txB_ctenar_jmeno;
        private System.Windows.Forms.TextBox txB_kniha_jmeno;
        private System.Windows.Forms.Label lbl_kniha_dostupna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txB_kniha_ID;
        private System.Windows.Forms.TextBox txB_ctenari_hledat;
        private System.Windows.Forms.TextBox txB_knihy_hledat;
        private System.Windows.Forms.ToolStripMenuItem podleČtenářůToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podleKnihToolStripMenuItem;
    }
}

