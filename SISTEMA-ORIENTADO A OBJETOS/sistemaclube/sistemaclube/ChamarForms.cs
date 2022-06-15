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
    public class ChamarForms
    {
        Control control = new Control(); 
   
        public void Abrir_Form_Login()
        {
            this.control.Hide();
            frlogin form = new frlogin();
            form.Show();
                }
        public void Abrir_Form_ADM()
        {
            this.control.Hide();
            fradm form = new fradm();
            form.Show(); 
            MessageBox.Show("Bem-vindo(a) adinistrador(a)!", "Entrou no sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Abrir_For_Zelador()
        {
            this.control.Hide();
            frzelador form = new frzelador();
            form.Show();
            MessageBox.Show("Bem-vindo(a) zelador(a)!", "Entrou no sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Abrir_Form_Usuario()
        {
            this.control.Hide();
            frusuario form = new frusuario();
            form.Show();
        }
        public void Abrir_Form_Cad_Quadra()
        {
            control.Hide();
            Frcadquad form = new Frcadquad();
            form.Show();
        }
        public void Abrir_Form_Reserva()
        {
            this.control.Hide();
            frreserva form = new frreserva();
            form.Show();
        }
    }
}
