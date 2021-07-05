using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Clases
{
    class Productos
    {
        public string ProdCodigo;
        public string ProdDescripcion;
        public string ProdCantStock;
        public string ProdUnidadMed;
        public string ProMargenGanancia;

        public Productos()
        {

        }
        public Productos(string Codigo, string Descripcion, string CantStock, string UnidadMed, string MargenGanancia)
        {
            this.ProdCodigo = Codigo;
            this.ProdDescripcion = Descripcion;
            this.ProdCantStock = CantStock;
            this.ProdUnidadMed = UnidadMed;
            this.ProMargenGanancia = MargenGanancia;
        }
    }
}
