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
          
            Login l = new Login(textBox1_LOGIN.Text, textBox2_SENHA.Text);

            l.Validacao(textBox1_LOGIN.Text, textBox2_SENHA.Text);

        }
        public void UserNaoEncontrado()
        {
            textBox1_LOGIN.Text = "";
            textBox2_SENHA.Text = "";
        }
       
        public void FecharTela()
        {
            this.Hide();
            this.Close();

        }
        private void frlogin_Load(object sender, EventArgs e)
        {
}
        
    }
}
