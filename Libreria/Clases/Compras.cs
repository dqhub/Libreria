using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Clases
{
    class Compras
    {
        public string CompFecha;
        public string CompProvID;
        public string CompFacturaTipo;
        public string CompFacturaPuntoVenta;
        public string CompFacturaNroComprobante;
        public string CompCondCompra;

        public string CompPrecioUnitProd;

        public Compras()
        {

        }

        public Compras(string Fecha, string ProveedorID, string FacturaTipo, string PuntoVenta, string NroComprobante, string CondCompra)
        {
            this.CompFecha = Fecha;
            this.CompProvID = ProveedorID;
            this.CompFacturaTipo = FacturaTipo;
            this.CompFacturaPuntoVenta = PuntoVenta;
            this.CompFacturaNroComprobante = NroComprobante;
            this.CompCondCompra = CondCompra;
        }
    }
}
