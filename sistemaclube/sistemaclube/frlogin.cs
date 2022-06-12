using MySql.Data.MySqlClient;
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

        private void button1_logar_Click(object sender, EventArgs e)
        {
            if (textBox1_LOGIN.Text == "" || textBox2_SENHA.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MySqlConnection mConn = new
           MySqlConnection("server=localhost;" +
           "database=sistema;" +
           "uid=root;pwd=Gata1203");

                mConn.Open();

                //TESTE ALO GIT
                MySqlCommand comando = new MySqlCommand("" +
                    "select * from USUARIO where LOGIN= '" + textBox1_LOGIN.Text +
                    "' and SENHA= '" + textBox2_SENHA.Text + "'" +
                    "and BLOQUEADO = 'N';", mConn);

                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter a = new MySqlDataAdapter(comando);
                a.Fill(dt);

                short i = Convert.ToInt16(dt.Rows.Count.ToString());

                //teste
                if (i > 0)
                {
                    MySqlCommand comando2 = new MySqlCommand("" +
                   "select * from USUARIO where LOGIN= '" + textBox1_LOGIN.Text +
                   "' and SENHA= '" + textBox2_SENHA.Text +
                   "'and FUNCAO = 'Adiministrador(a)';", mConn);

                    comando.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    MySqlDataAdapter a2 = new MySqlDataAdapter(comando2);
                    a2.Fill(dt2);

                    short VAR_ADM = Convert.ToInt16(dt2.Rows.Count.ToString());

                    if (VAR_ADM > 0)
                    {
                        fradm form_adm = new fradm();
                        this.Hide();
                        form_adm.Show();
                        MessageBox.Show("Bem-vindo(a) adinistrador(a)!", "Entrou no sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        frzelador form_zelador = new frzelador();
                        this.Hide();
                        form_zelador.Show();
                        MessageBox.Show("Bem-vindo(a) zelador(a)!", "Entrou no sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Login inválido ou usuário bloqueado!");
                    textBox1_LOGIN.Text = "";
                    textBox2_SENHA.Text = "";
                }

                mConn.Close();
            }
        }
        private void frlogin_Load(object sender, EventArgs e)
        {
}
        
    }
}
