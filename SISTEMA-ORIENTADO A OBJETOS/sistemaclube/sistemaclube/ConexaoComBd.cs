using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaclube
{ 
    class ConexaoComBd
    {
        MySqlConnection mConn = new
MySqlConnection("server=localhost;" +
        "database=sistema;" +
        "uid=root;pwd=Gata1203");
        string query;
       
        public  ConexaoComBd(String q)
        {
            query = q;
        }

        public void comando(String q)
        {
            mConn.Open();

            MySqlCommand comando = new MySqlCommand(q + "",mConn);
            comando.ExecuteReader();
            mConn.Close();
        }

        public string exibir(String q)
        {

            return ""; 
        }


    }
}
