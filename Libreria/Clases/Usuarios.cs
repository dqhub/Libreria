using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Clases
{
    class Usuarios
    {
        public string UserNombre;
        public string UserCuenta;
        public string UserContraseña;
        public string UserTipoCuenta;
        public string UserEstadoCuenta;

        public Usuarios()
        {

        }

        public Usuarios(string Nombre, string Cuenta, string Contraseña, string TipoCuenta, string EstadoCuenta)
        {
            this.UserNombre = Nombre;
            this.UserCuenta = Cuenta;
            this.UserContraseña = Contraseña;
            this.UserTipoCuenta = TipoCuenta;
            this.UserEstadoCuenta = EstadoCuenta;
        }
    }
}
