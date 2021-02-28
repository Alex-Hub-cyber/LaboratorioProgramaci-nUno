using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramaciónUno .Dominio
{
    class Login
    {

        private String Usuario;
        private String Contraseña;

        public string GetUsuario()
        {
            return GetUsuario();
        }

        public void SetUsuario(string value)
        {
            SetUsuario(value);
        }

        public string Password { get => Contraseña ; set => Contraseña  = value; }
        public object USUARIO { get; internal set; }
        public object CONTRASEÑA { get; internal set; }

        internal int acceso(Login log)
        {
            throw new NotImplementedException();
        }
    }
}
