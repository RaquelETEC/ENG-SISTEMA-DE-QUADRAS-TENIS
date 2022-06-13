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
    public partial class frzelador : Form
    {
        public frzelador()
        {
            InitializeComponent();
        }

        private void bt_reserva_Click(object sender, EventArgs e)
        {
            if (controle.formreserva == null)
                controle.formreserva = new frreserva();
                
                controle.formreserva.Show();
                this.Hide();
                controle.formreserva.Focus();

        }
    }
}