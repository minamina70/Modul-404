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
    //Zustand 4: Bankomat wartet auf Bestätigung im Untermenu
    public partial class UnterMenuSaldo : Form
    {
        public UnterMenuSaldo()
        {
            InitializeComponent();
        }
        private void GeheInZustandUnterMenu()
        {
            lblUntermenu.Text = "Ihr aktueller Saldo beträgt: \n" + string.Format("{0:f2}", Form1.saldo) + " CHF";
        }

        private void UnterMenuSaldo_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
            GeheInZustandUnterMenu();
        }

        private void ButtonWeiter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.frmMenu.Show();
        }
    }
}
