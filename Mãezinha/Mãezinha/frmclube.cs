using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mãezinha
{
    public partial class frmclube : Form
    {
        public frmclube()
        {
            InitializeComponent();
        }

        private void btcadquad_Click(object sender, EventArgs e)
        {
            if (controle.formquadra == null)
                controle.formquadra = new frmquadra();

            controle.formquadra.Show();
            controle.formquadra.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
