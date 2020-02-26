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
    //Zustand 3: Bankomat wartet auf Menu-Wahl

    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonSaldo_Click(object sender, EventArgs e)
        {
            Form1.frmUnterMenuSaldo.Show();
        }

        private void ButtonEnde_Click(object sender, EventArgs e)
        {
            Form1.frmKartenEntnahme.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
        }
    }
}
