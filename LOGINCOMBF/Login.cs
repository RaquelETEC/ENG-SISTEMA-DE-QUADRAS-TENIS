﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace LOGINCOMBF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* String conexao = "Server=locahost;Database=sistema;Uid=root;password=1234;SsLmODE=none";
            var Conection = new MySqlConnection(conexao);
            var comand = Conection.CreateCommand();
            MySqlCommand query = new MySqlCommand("'Select count(*) from usuario where LOGIN ='" + textBox1_LOGIN + "' and SENHA '" + textBox2_SENHA + " ' ", Conection);
            Conection.Open();
            DataTable datatable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(datatable);

            foreach(DataRow list in datatable.Rows)
            {

            }
            Conection.Close();
          */
        }
        

        private void button1_logar_Click(object sender, EventArgs e)
        {
             MySqlConnection mConn = new
             MySqlConnection("server=localhost;database=sistema;uid=root;pwd=1234");

             mConn.Open();

             //TESTE ALO GIT
             MySqlCommand comando = new MySqlCommand("select * from USUARIO where LOGIN= '" + textBox1_LOGIN.Text + "' and SENHA= '" + textBox2_SENHA.Text + "';", mConn);
             comando.ExecuteNonQuery();
             DataTable dt = new DataTable();
             MySqlDataAdapter a = new MySqlDataAdapter(comando);
             a.Fill(dt);

             short i = Convert.ToInt16(dt.Rows.Count.ToString());


                 if (i > 0)
                 {
                 Menu_Inicial Principal = new Menu_Inicial();
                 this.Hide();
                 Principal.Show();
             }
                 else
                 {
                     MessageBox.Show("Login inválido");
                textBox1_LOGIN.Text = "";
                textBox2_SENHA.Text = "";
             }

                 mConn.Close();

       


        }
    }
   
}