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

namespace LOGINCOMBF
{
    public partial class Cad_Usuario : Form
    {

         

        public Cad_Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisualizaUsuario VisUS = new VisualizaUsuario();
            VisUS.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                if (Txt_Nome.Text == "" || txt_senha.Text == "" || listBox1.Text == "" || listBox2.Text == "")
                {
                    MessageBox.Show("PREENCHA TODOS OD CAMPOS", "messagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   MySqlConnection mConn = new
                   MySqlConnection("server=localhost;database=sistema;uid=root;pwd=1234");

                    mConn.Open();

                    //TESTE ALO GIT
                    MySqlCommand comando = new MySqlCommand(
                        "INSERT INTO USUARIO (LOGIN,SENHA,FUNCAO,BLOQUEADO)" +
                        "VALUES ('" + Txt_Nome.Text + "','" + txt_senha.Text + "','"+ listBox1.Text +"','"+ listBox2.Text +"');", mConn);

                    comando.ExecuteReader();

                    MessageBox.Show("USUARIO CADASTRADO!", "messagem",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mConn.Close();
                    this.Hide();
                }
            }
            catch (Exception )
            {
                MessageBox.Show("ALGO DEU ERRADO", "messagem",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
