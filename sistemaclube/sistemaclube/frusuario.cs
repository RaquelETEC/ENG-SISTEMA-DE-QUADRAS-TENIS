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
    public partial class frusuario : Form
    {
        public frusuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void frusuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.sistemaDataSet.usuario);

        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            this.usuarioBindingSource.AddNew();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            if (lOGINTextBox.Text == "" || sENHATextBox.Text == "" || bLOQUEADOComboBox.Text == "" || fUNCAOComboBox.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatorios (*)", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.Validate();
                this.usuarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
                MessageBox.Show("Cadastro salvo com sucesso!", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.usuarioBindingSource.CancelEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
            MessageBox.Show("Cadastro cancelado com sucesso!", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esse item?", "Confirmação cadastro de usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.usuarioBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
            MessageBox.Show("cadastro excluido com sucesso!", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btsair2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
