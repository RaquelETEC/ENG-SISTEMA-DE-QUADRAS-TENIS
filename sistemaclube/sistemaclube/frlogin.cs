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
    public partial class frlogin : Form
    {
        public frlogin()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.sistemaDataSet.usuario);

        }

        private void sENHALabel_Click(object sender, EventArgs e)
        {

        }
        private void efetualogin()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tx_lOGIN.Text == "beatriz@gmail.com" && tx_SENHA.Text == "Gata1203" && cb_fUNCAO.Text == "Adiministrador")
            {

                if (controle.formadm == null)
                {
                    controle.formadm = new fradm();
                    this.Hide();
                    controle.formadm.Show();
                    controle.formadm.Focus();

                    MessageBox.Show("bem vindo ao sistema!");
                }
                else
                {
                   MessageBox.Show("verifique se o e-mail ou a senha estão corretos!");
                }
                    

                
            }    
        }

        private void bt_zelador_Click(object sender, EventArgs e)
        {
            if (controle.formzelador == null)
            {
                controle.formzelador = new frzelador();
                this.Hide();
                controle.formzelador.Show();
                controle.formzelador.Focus();             
            }
        }   
    }
}
