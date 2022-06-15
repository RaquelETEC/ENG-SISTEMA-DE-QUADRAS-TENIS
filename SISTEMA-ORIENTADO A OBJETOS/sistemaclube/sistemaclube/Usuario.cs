using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaclube
{
    class Usuario
    {
        public String EMAIL;
        public String SENHA;
        public String BLOQUEADO;
        public String FUNCAO;
        public String CODID; 

       

        //construtor 
        public Usuario(string E, String S, String B, String F,String ID)
        {
            this.EMAIL = E;
            this.SENHA = S;
            this.BLOQUEADO = B;
            this.FUNCAO = F;
            this.CODID = ID;
        }

        ConexaoComBd Cone = new ConexaoComBd("");
   

        public int CadastrarUsuario(string E, String S, String B, String F)
        {
            if (E == "" && S == "" && B == "" && F == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatorios (*)", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cone.comando(" INSERT INTO USUARIO(LOGIN, SENHA, FUNCAO, BLOQUEADO)" +
                    "VALUES ('" + E + "','" + S + "','" + F + "','" + B + "');");
                MessageBox.Show("USUARIO CADASTRADO!", "messagem",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                return 0; 
        }
        public int AlterarUsuario(string E, String S, String B, String F,String ID)
        {
            if (CODID == "")
            {
                MessageBox.Show("SELECIONE UM REGISTRO!", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cone.comando(" UPDATE usuario SET `LOGIN` = '" + E + "'," +
                        "`SENHA` = '" + S + "'," +
                         "`BLOQUEADO` = '" + B + "'," +
                         "`FUNCAO` = '" + F + "'" +
                         "WHERE(`ID_USUARIO` =" + ID + "); ");

                MessageBox.Show("USUARIO ATUALIZADO!", "messagem",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            return 0;
        }
        public int ApagarUsuario(string E, String S, String B, String F, String ID)
        {
            if (CODID == "")
            {
                MessageBox.Show("SELECIONE UM REGISTRO!", "ATENÇÃO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esse item?", "Confirmação cadastro de usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 Cone.comando(" DELETE FROM usuario WHERE ID_USUARIO = " + ID);
                MessageBox.Show("cadastro excluido com sucesso!", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return 0;
        }
        public String ExibirUsuario()
        {
            string linha_listview;
            linha_listview =  Cone.exibir("SELECT * FROM usuario ");
            return linha_listview; 
        }
    }
}
