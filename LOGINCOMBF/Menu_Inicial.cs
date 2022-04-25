using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGINCOMBF
{
    public partial class Menu_Inicial : Form
    {
        public Menu_Inicial()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cad_Usuario VisUS = new Cad_Usuario();
            VisUS.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cad_Quadra visu_quadra = new Cad_Quadra();
            visu_quadra.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cad_Reservas Visu_Reserva = new Cad_Reservas();
            Visu_Reserva.Show();
            this.Hide();
        }
    }
}
