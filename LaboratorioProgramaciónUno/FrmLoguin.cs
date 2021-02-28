using LaboratorioProgramaciónUno.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LaboratorioProgramaciónUno
{
    public partial class Loguin : Form
    {
        internal string CONTRASEÑA;
        private bool Bienvenido;
        private object txtContraseña;

        public Loguin()
        {
            InitializeComponent();


            {

                Login log = new Login();
                log.USUARIO = TxtUsuario.Text;
                log.CONTRASEÑA = TxtContraseña.Text;

                frmLogin clsL = new FrmLogin();

                int variableevalucion = clsL.acceso(log);

                if (variableevalucion == 1)
                {

                    MessageBox.Show("WELCOME");

                }
                else
                {
                    MessageBox.Show("Bienvenido");
                }

            }
        }

        internal int acceso(object loguin)
        {
            throw new NotImplementedException();
        }

        private void FrmLog(object sender, EventArgs e)
        {

        }
    }

    internal class FrmLogin : frmLogin
    {
    }

    internal class frmLogin
    {
        internal int acceso(Login log)
        {
            throw new NotImplementedException();
        }
    }
}