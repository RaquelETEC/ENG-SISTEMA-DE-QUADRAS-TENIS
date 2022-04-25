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
    public partial class Cad_Reservas : Form
    {
        public Cad_Reservas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nome.Text == "" || txt_CPF.Text == "" || txt_pag.Text == "" || txt_quadra.Text == "" || txt_pag.Text == "" ) 
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
                            "INSERT INTO RESERVA (" +
                            "NOME_CLIENTE," +
                            "CPF_CLIENTE," +
                            "PAGAMENTO," +
                            "ID_QUADRA," +
                            "NOME_QUADRA," +
                            "HORA_QUADRA)"+  
                        "VALUES ('" + 
                        txt_Nome.Text + "','" +
                        txt_CPF.Text + "','" +
                        txt_pag.Text + "','" +
                        txt_idquadra.Text + "','" +
                        txt_quadra.Text + "','" +
                        txt_data.Text + "');", mConn);

                    comando.ExecuteReader();

                    MessageBox.Show("RESERVA CADASTRADA!", "messagem",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_Nome.Text = "";
                    txt_CPF.Text = "";
                    txt_pag.Text = "";
                    txt_idquadra.Text = "";
                    txt_quadra.Text = "";
                    txt_data.Text = "";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("ALGO DEU ERRADO", "messagem",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
