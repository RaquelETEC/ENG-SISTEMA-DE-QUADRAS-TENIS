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
    class Login
    {
        ChamarForms abrir = new ChamarForms();
        frlogin frm = new frlogin();
        public String login_usu;
        public String senha_usu;


        public Login(string l, String s)
        {
            this.login_usu = l;
            this.senha_usu = s;

        }
        public void Validacao(string l, String s)
        {
            autentificacao Aten_Obj = new autentificacao(l, s);


            if (login_usu == "" || senha_usu == "")
            {
                MessageBox.Show("Preencha todos os campos!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i;
                i = Aten_Obj.VerificaSeExiste(this.login_usu, this.senha_usu);

                if (i > 0)
                {
                    int VAR_ADM;

                    VAR_ADM = Aten_Obj.VerificaSeAdm(this.login_usu, this.senha_usu);
                    if (VAR_ADM > 0)
                    {
                        frm.FecharTela(); 
                        abrir.Abrir_Form_ADM();

                    }
                    else
                    {
                        frm.Close(); 
                        abrir.Abrir_For_Zelador();
                    }
                }
                else
                {
                    MessageBox.Show("Login inválido ou usuário bloqueado!");

                   
                    frm.UserNaoEncontrado(); 

                }


            }




        }
    }
}

