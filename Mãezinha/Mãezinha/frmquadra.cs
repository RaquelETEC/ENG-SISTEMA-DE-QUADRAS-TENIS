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
    public partial class frmquadra : Form
    {
        public frmquadra()
        {
            InitializeComponent();
        }

        private void cadastroquadraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroquadraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmquadra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.Cadastroquadra'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroquadraTableAdapter.Fill(this.cadastroDataSet.Cadastroquadra);

        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            this.cadastroquadraBindingSource.AddNew();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroquadraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);
            MessageBox.Show("Cadastro salvo com sucesso!", "Cadastro de quadra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.cadastroquadraBindingSource.CancelEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);
            MessageBox.Show("Cadastro cancelado com sucesso!", "Cadastro de quadra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja exluir esse item?", "Confirmação cadastro de quadra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.cadastroquadraBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);
            MessageBox.Show("cadastro excluido com sucesso!", "Cadastro de quadra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void n__de_quadraLabel_Click(object sender, EventArgs e)
        {

        }

        private void btsair2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
