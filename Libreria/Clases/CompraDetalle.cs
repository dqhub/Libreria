using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Clases
{
    class CompraDetalle
    {
        public int CompraDetFactID;
        public string CompraDetProdID;
        public string CompraDetCantidadProd;
        public string CompraDetPrecioUnitProd;

        public CompraDetalle()
        {

        }

        public CompraDetalle(int DetFactID, string DetProdID, string CantidadProd, string PrecioUnitProd)
        {
            this.CompraDetFactID = DetFactID;
            this.CompraDetProdID = DetProdID;
            this.CompraDetCantidadProd = CantidadProd;
            this.CompraDetPrecioUnitProd = PrecioUnitProd;
        }
    }
}
