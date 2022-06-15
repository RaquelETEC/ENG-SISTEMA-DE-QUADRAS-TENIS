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
        Validacao con = new Validacao("", "");
        Usuario Us = new Usuario("", "", "", "", "");

        public frusuario()
        {
            InitializeComponent();

            ;//View1 = Us.ExibirUsuario(); 
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
            lOGINTextBox.Text = con.LimparCampos();
            sENHATextBox.Text = con.LimparCampos();
            bLOQUEADOComboBox.Text = con.LimparCampos();
            fUNCAOComboBox.Text = con.LimparCampos();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {

       

            //chamando o metodo cadastrar
            Us.CadastrarUsuario(lOGINTextBox.Text,
                       sENHATextBox.Text,
                       bLOQUEADOComboBox.Text,
                       fUNCAOComboBox.Text);
           
        }
        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.usuarioBindingSource.CancelEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
            MessageBox.Show("Cadastro cancelado com sucesso!", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            //chamando o metodo cadastrar
            Us.ApagarUsuario(lOGINTextBox.Text,
                       sENHATextBox.Text,
                       bLOQUEADOComboBox.Text,
                       fUNCAOComboBox.Text,
                       textid.Text);
        }

        private void btsair2_Click(object sender, EventArgs e)
        {
            ChamarForms C = new ChamarForms();
            C.Abrir_Form_ADM();
            this.Hide(); 
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            ChamarForms C = new ChamarForms();
            C.Abrir_Form_ADM();
            this.Hide();
        }

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
