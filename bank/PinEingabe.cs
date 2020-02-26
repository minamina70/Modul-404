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
    public partial class PinEingabe : Form
    {
        //Zustand 2: Bankomat wartet auf die Eingabe der PIN

        string passWort = "1234";
        public PinEingabe()
        {
            InitializeComponent();
        }

        private void GeheInZustandPinErwarten()
        {
            txtPW.Text = "";
            lblAnleitung.Text = "Bitte geben Sie Ihr Passwort ein";
            Form1.pwFalsch = 0;
        }
        public void SetzePasswort(string pw)
        {
            passWort = pw;
        }

        private void PinEingabe_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
            GeheInZustandPinErwarten();
        }
        private void ButtonPW_Click(object sender, EventArgs e)
        {
            if (txtPW.Text == passWort)
            {
                Form1.frmMenu.Show();
                this.Hide();
            }
            else
            {
                Form1.pwFalsch += 1;
                if (Form1.pwFalsch >= 3)
                {
                    Form1.frmKartenEntnahme.Show();
                    this.Hide();
                }
                else
                {
                    txtPW.Text = "";
                    lblAnleitung.Text = "Der Pin ist falsch, versuchen Sie es erneut. Sie haben noch " + Convert.ToString(3 - Form1.pwFalsch) + " Versuch(e)";
                }
            }
        }

        private void btnAbbruch_Click(object sender, EventArgs e)
        {
            Form1.frmKartenEntnahme.Show();
            this.Hide();
        }
    }
}
