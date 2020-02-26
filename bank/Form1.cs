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
    //Zustand 1: Bankomat wartet auf die Eingabe der Karte
    public partial class Form1 : Form
    {
        public static PinEingabe frmPinEingabe = new PinEingabe();
        public static Menu frmMenu = new Menu();
        public static UnterMenuSaldo frmUnterMenuSaldo = new UnterMenuSaldo();
        public static KartenEntnahme frmKartenEntnahme = new KartenEntnahme();

        public static Boolean karteValid =true;
        public static double saldo = 0;
        public static int pwFalsch;
        public Form1()
        {
            InitializeComponent();
        }
        private void EingebenKartendaten(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
            karteValid = chkKarteValid.Checked;
            if (txtPWStart.TextLength > 0)
            {
                frmPinEingabe.SetzePasswort( txtPWStart.Text);
            }
            else frmPinEingabe.SetzePasswort("1234");
            if ((txtSaldo.TextLength) > 0)
            {
                saldo = Convert.ToDouble(txtSaldo.Text) ;
            }
            else saldo = 0;
        }

        private void KarteEin_Click(object sender, EventArgs e)
        {
            if (karteValid==true)
            {
                frmPinEingabe.Show();
            }
            else
            {
                frmKartenEntnahme.Show();
            }
        }
    }
}
