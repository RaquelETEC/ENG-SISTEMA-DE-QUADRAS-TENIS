using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace sistemaclube
{
    class Validacao
    {
        MySqlConnection mConn = new
 MySqlConnection("server=localhost;" +
         "database=sistema;" +
         "uid=root;pwd=Gata1203");

        //atributos
        public String login;
        public String senha;  

        //metodo construtor 
        //metodo q tem o mesmo nome da clase e vai servir para
        //atribuir valores aos atributos 

        public Validacao(string l, String s)
        {
            this.login = l;
            this.senha = s; 

            //cada objetos (l e s ) no metodo construtor sera atribuido as variavceis login e senha 
        }
        public String LimparCampos()
        {
            return "";
        }
     

        public int VerificaSeExiste(string l, String s)
        {

            mConn.Open();

            MySqlCommand comando = new MySqlCommand("" +
                "select * from USUARIO where LOGIN= '" + l +
                "' and SENHA= '" + s + "'" +
                "and BLOQUEADO = 'N';", mConn);

            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter a = new MySqlDataAdapter(comando);
            a.Fill(dt);

            short i = Convert.ToInt16(dt.Rows.Count.ToString());

            return i; 
        }

        public int VerificaSeAdm (string l, String s)
        {
            MySqlCommand comando = new MySqlCommand("" +
                "select * from USUARIO where LOGIN= '" + l +
                "' and SENHA= '" + s + "'" +
                "and  FUNCAO = 'Adiministrador(a)';", mConn);

            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter a = new MySqlDataAdapter(comando);
            a.Fill(dt);

            short i = Convert.ToInt16(dt.Rows.Count.ToString());

            return i;


        }

       
    }
}
