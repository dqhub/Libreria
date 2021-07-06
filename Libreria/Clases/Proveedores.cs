using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Clases
{
    class Proveedores
    {
        public string ProvCUIT;
        public string ProvNombreRS;
        public string ProvDomicilio;
        public string ProvIngBrutos;
        public string ProvCondicionIVA;
        public string ProvCondicionVenta;
        public string ProvContacto;
        public string ProvMail;
        public string ProvTelefono1;
        public string ProvTelefono2;

        public Proveedores()
        {

        }
        public Proveedores(string CUIT, string NombreRS, string Domicilio, string IngBrutos, string CondicionIVA, string CondicionVenta, string Contacto, string Mail, string Telefono1, string Telefono2)
        {
            this.ProvCUIT = CUIT;
            this.ProvNombreRS = NombreRS;
            this.ProvDomicilio = Domicilio;
            this.ProvIngBrutos = IngBrutos;
            this.ProvCondicionIVA = CondicionIVA;
            this.ProvCondicionVenta = CondicionVenta;
            this.ProvContacto = Contacto;
            this.ProvMail = Mail;
            this.ProvTelefono1 = Telefono1;
            this.ProvTelefono2 = Telefono2;
        }
    }
}
