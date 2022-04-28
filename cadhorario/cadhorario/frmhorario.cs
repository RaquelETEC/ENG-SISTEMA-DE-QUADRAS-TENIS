using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadhorario
{
    public partial class frmhorario : Form
    {
        public frmhorario()
        {
            InitializeComponent();
        }

        private void tb_horarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_horarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_quadras'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_quadrasTableAdapter.Fill(this.cadastroDataSet.tb_quadras);
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_horario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_horarioTableAdapter.Fill(this.cadastroDataSet.tb_horario);

        }

        private void tb_horarioBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            this.tb_horarioBindingSource.AddNew();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_horarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);
            MessageBox.Show("Cadastro salvo com sucesso!", "Cadastro de quadra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.tb_horarioBindingSource.CancelEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);
            MessageBox.Show("Cadastro cancelado com sucesso!", "Cadastro de quadra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja exluir esse item?", "Confirmação cadastro de quadra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.tb_horarioBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.cadastroDataSet);
                MessageBox.Show("cadastro excluido com sucesso!", "Cadastro de quadra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btsair2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
