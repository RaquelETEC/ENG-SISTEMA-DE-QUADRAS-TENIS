using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaclube
{
    public partial class fradm : Form
    {
        public fradm()
        {
            InitializeComponent();
        }

        private void bt_quad_Click(object sender, EventArgs e)
        {
            if (controle.formquad == null)
                controle.formquad = new Frcadquad();
                
                controle.formquad.Show();
                this.Hide();
                controle.formquad.Focus();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (controle.formusuario == null)
                controle.formusuario = new frusuario();
                
                controle.formusuario.Show();
                this.Hide();
                controle.formusuario.Focus();

        }

        private void bt_relat_Click(object sender, EventArgs e)
        {
            if (controle.formrelat == null)
                controle.formrelat = new relat();

            controle.formrelat.Show();
            this.Hide();
            controle.formrelat.Focus();


        }
    }
}
