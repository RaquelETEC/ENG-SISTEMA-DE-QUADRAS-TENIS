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
    public partial class Frcadquad : Form
    {
        public Frcadquad()
        {
            InitializeComponent();
        }

        private void Frcadquad_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaDataSet.cad_quadra'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_quadraTableAdapter.Fill(this.sistemaDataSet.cad_quadra);

        }

        private void bLOQUEADOLabel_Click(object sender, EventArgs e)
        {

        }

        private void bLOQUEADOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            this.cad_quadraBindingSource.AddNew();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cad_quadraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
            MessageBox.Show("Cadastro salvo com sucesso!", "Cadastro de quadra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.cad_quadraBindingSource.CancelEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
            MessageBox.Show("Cadastro cancelado com sucesso!", "Cadastro de quadra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja exluir esse item?", "Confirmação cadastro de quadra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.cad_quadraBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
            MessageBox.Show("cadastro excluido com sucesso!", "Cadastro de quadra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btsair2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {

            if (controle.formadm == null)
            {
                controle.formadm = new fradm();
                this.Hide();
                controle.formadm.Show();
                controle.formadm.Focus();
            }

        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            if (controle.formadm == null)
                controle.formadm = new fradm();
                
                controle.formadm.Show();
                this.Hide();
                controle.formadm.Focus();

        }
    }
}
