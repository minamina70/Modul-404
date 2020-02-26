using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat_bb
{
    public partial class KartenEntnahme : Form
    {
        //Zustand 5: Bankomat wartet auf die Entnahme der Karte
        public KartenEntnahme()
        {
            InitializeComponent();
        }
        private void GeheInZustandKartenEntnahme()
        {
            lblAnleitung.Text += "\nVielen Dank für Ihren Besuch."; 
            if (Form1.karteValid == false) lblAnleitung.Text = "Ihre Karte ist nicht valid.\n"+ lblAnleitung.Text;
            if (Form1.pwFalsch >= 3) {lblAnleitung.Text = "Sie haben 3 Mal den falschen PIN eingegeben\n" + lblAnleitung.Text;Form1.pwFalsch=0;}
        }

        private void KartenEntnahme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
            GeheInZustandKartenEntnahme();
        }
        private void KarteAus_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
