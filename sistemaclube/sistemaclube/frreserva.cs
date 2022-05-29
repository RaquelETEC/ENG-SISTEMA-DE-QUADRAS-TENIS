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
    public partial class frreserva : Form
    {
        public frreserva()
        {
            InitializeComponent();
        }

        private void reservaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);

        }

        private void frreserva_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaDataSet.cad_quadra'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_quadraTableAdapter.Fill(this.sistemaDataSet.cad_quadra);
            // TODO: esta linha de código carrega dados na tabela 'sistemaDataSet.reserva'. Você pode movê-la ou removê-la conforme necessário.
            this.reservaTableAdapter.Fill(this.sistemaDataSet.reserva);

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            this.reservaBindingSource.AddNew();
        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            if (tIPO_RESERVAComboBox.Text == "" || hORA_INICIOComboBox.Text == "" || hORA_FIMComboBox.Text == "" || nUM_QUADRAComboBox.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatorios (*)", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    "select * from reserva where HORA_INICIO= '" + hORA_INICIOComboBox.Text + "'" +
                    "and HORA_FIM= '" + hORA_FIMComboBox.Text + "'" +
                    "and  NUM_QUADRA = '" + nUM_QUADRAComboBox + "';", mConn);

                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter a = new MySqlDataAdapter(comando);
                a.Fill(dt);

                short i = Convert.ToInt16(dt.Rows.Count.ToString());

                //teste

                if (i > 0)
                {

                    MessageBox.Show("Horario ja Reservado!");

                    hORA_INICIOComboBox.Text = "";
                    hORA_FIMComboBox.Text = "";

                }
                else
                {
                    this.Validate();
                    this.reservaBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
                    MessageBox.Show("Reserva salva com sucesso!", "Reserva de quardas ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                mConn.Close();
            }

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.reservaBindingSource.CancelEdit();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
            MessageBox.Show("Reserva cancelada com sucesso!", "Reserva de quardas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esse item?", "Confirmação reserva de quadras", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.reservaBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.sistemaDataSet);
            MessageBox.Show("Reserva excluida com sucesso!", "Reserva de quardas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
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
