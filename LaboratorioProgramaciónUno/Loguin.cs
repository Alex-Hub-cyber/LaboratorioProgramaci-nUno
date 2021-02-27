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
        private bool Bienvenido;
        private object txtContraseña;

        public Loguin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEntrar_Click(object sender, EventArgs e)
        {
            {
                Login log = new Login();
                log.Usuario = TxtUsuario.Text;
                log.Contraseña = txtContraseña;

                Login clsL = new Login();

                int variableevalucion = clsL.acceso(log);

                if (variableevalucion == 1)
                {

                    MessageBox.Show("WELCOME");

                }
                else
                {
                    MessageBox.Show("FALSE"); if ((Bienvenido))
                    {
                        MessageBox.Show("Login exitoso.");
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos.");
                    }
                }
            }
        }
    }

        
        
         
        

      
        
           
namespace LaboratorioProgramaciónUno
    {
        class ClsListaUsuarios
        {
            private const string V = "Carlos";
            private const string V1 = "123";
            
        }
    }
    }

    internal class Login
    {
        
        internal object Contraseña;

        public string Usuario { get; internal set; }

        internal int acceso(Login log)
        {
            throw new NotImplementedException();
        }
    }
    
    
