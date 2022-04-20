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
    public partial class VisualizaUsuario : Form
    {
        public VisualizaUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
               Cad_Usuario Cad_US = new Cad_Usuario();
              Cad_US.Show();
        }
    }
}
