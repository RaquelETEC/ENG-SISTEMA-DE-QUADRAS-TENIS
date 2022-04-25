using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
namespace LOGINCOMBF
{
    public partial class Cad_Quadra : Form
    {


        private MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Cad_Quadra()
        {
            InitializeComponent();
        }

        private void BTN_CAD_Click(object sender, EventArgs e)
        {
           DateTime data = DateTime.Parse("dd / MM / yyyy", System.Globalization.CultureInfo.InvariantCulture);
            try
            {
                if (txt_Nome.Text == "" || txt_coberta.Text == "" || txt_preco.Text == "" )
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
                        "INSERT INTO QUADRA (NOME_QUADRA,COBERTA,VALOR)" +
                        "VALUES ('" + txt_Nome.Text + "','" +
                        txt_coberta.Text + "','" +
                        txt_preco.Text+ "');", mConn);

                    comando.ExecuteReader();

                    MessageBox.Show("USUARIO CADASTRADO!", "messagem",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                for (int i = 0; i <60; i++){

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ALGO DEU ERRADO", "messagem",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cad_Quadra_Load(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new MySqlConnection("server = localhost; database = sistema; uid = root; pwd = 1234");
                strSQL = ("SELECT * FOM QUADRA");

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dti = new DataTable();

                da.Fill(dti);

               dgvDados = dti;


            }
            catch (Exception)
            {
                MessageBox.Show("ALGO DEU ERRADO", "messagem",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
    }
}
