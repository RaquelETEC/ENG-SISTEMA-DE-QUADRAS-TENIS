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
    public partial class frreserva : Form
    {
        public frreserva()
        {
            InitializeComponent();
        }

        private void reservaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void frreserva_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaDataSet.cad_quadra'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_quadraTableAdapter.Fill(this.sistemaDataSet.cad_quadra);
            // TODO: esta linha de código carrega dados na tabela 'sistemaDataSet.reserva'. Você pode movê-la ou removê-la conforme necessário.
            this.reservaTableAdapter.Fill(this.sistemaDataSet.reserva);

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
