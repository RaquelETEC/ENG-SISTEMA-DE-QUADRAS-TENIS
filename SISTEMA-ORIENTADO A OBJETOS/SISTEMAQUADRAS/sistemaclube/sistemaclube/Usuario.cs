using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaclube
{
    class Usuario
    {
        public String EMAIL;
        public String SENHA;
        public String BLOQUEADO;
        public String FUNCAO;

        public Usuario(string E, String S, String B, String F)
        {
            EMAIL = E;
            SENHA = S;
            BLOQUEADO = B;
            FUNCAO = F;
        }

        public int CadastrarUsuario(string E, String S, String B, String F)
        {
            return 0; 
        }
        public int AlterarUsuario(string E, String S, String B, String F)
        {
            return 0;
        }
        public int ApagarUsuario(string E, String S, String B, String F)
        {
            return 0;
        }
        public void ExibirUsuario()
        {

        }
    }
}
