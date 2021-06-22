using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Clases
{
    class Clientes
    {
        public string ClieCUIT;
        public string ClieNombreRS;
        public string ClieDomicilio;
        public string ClieIngBrutos;
        public string ClieCondicionIVA;
        public string ClieContacto;
        public string ClieMail;
        public string ClieTelefono1;
        public string ClieTelefono2;

        public Clientes()
        {

        }

        public Clientes(string CUIT, string NombreRS, string Domicilio, string IngBrutos, string CondicionIVA, string Contacto, string Mail, string Telefono1, string Telefono2)
        {
            this.ClieCUIT = CUIT;
            this.ClieNombreRS = NombreRS;
            this.ClieDomicilio = Domicilio;
            this.ClieIngBrutos = IngBrutos;
            this.ClieContacto = Contacto;
            this.ClieCondicionIVA = CondicionIVA;
            this.ClieMail = Mail;
            this.ClieTelefono1 = Telefono1;
            this.ClieTelefono2 = Telefono2;
        }
    }
}
