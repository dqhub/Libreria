using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Libreria.Forms
{
    public partial class Frm_Compras : Form
    {
        bool editarEstado = false;
        bool DBVacia = true;
        bool dataGridCompras_porFacturas;

        int editarCompra_FactId;
        int editarCompra_porDetelleId;
        string var_ProvId;
        //int var_FactId;
        string var_ProdID;

        DataTable TablaProveedores = new DataTable();
        DataTable TablaProductos = new DataTable();

        public Frm_Compras()
        {
            InitializeComponent();
        }


        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** MÉTODOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        /******* MÉTODOS FUNCIONALES *******/

        public void CargarTablas()
        {
            //Realiza la carga de Autocompletado de txt_ProvCUIT

            string query = "SELECT * FROM proveedor";
            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            MySqlDataAdapter DBAdaptadorProv = new MySqlDataAdapter(query, DB);
            DBAdaptadorProv.Fill(TablaProveedores);

            AutoCompleteStringCollection listarProveedor = new AutoCompleteStringCollection();
            for (int i = 0; i < TablaProveedores.Rows.Count; i++)
            {
                listarProveedor.Add(TablaProveedores.Rows[i]["cuit"].ToString());
            }

            txt_ProvCUIT.AutoCompleteCustomSource = listarProveedor;

            //Realiza la carga de Autocompletado de txt_ProdCodigo

            string query2 = "SELECT * FROM producto";
            MySqlConnection DB2 = Clases.ConexionDB.ConectarDB();
            MySqlDataAdapter DBAdaptadorProd = new MySqlDataAdapter(query2, DB2);
            DBAdaptadorProd.Fill(TablaProductos);

            AutoCompleteStringCollection listarProducto = new AutoCompleteStringCollection();
            for (int i = 0; i < TablaProductos.Rows.Count; i++)
            {
                listarProducto.Add(TablaProductos.Rows[i]["codigo"].ToString());
            }

            txt_ProdCodigo.AutoCompleteCustomSource = listarProducto;
        }

        public void BuscarProductoID(string codigo)
        {
            var_ProdID = "";
            int y = 0;
            for (int x = 0; x < TablaProductos.Rows.Count; x++)
            {
                if (codigo == TablaProductos.Rows[x]["codigo"].ToString())
                    y = x;
            }
            var_ProdID = TablaProductos.Rows[y]["prodid"].ToString();
        }

        public void LimpiarForm_paraNuevaCargaFactura()
        {
            txt_ProvCUIT.Text = "";
            txt_ProvNombre.Text = "";
            cmb_CompFacturaTipo.Text = null;
            txt_CompFacturaPuntoVenta.Text = "";
            txt_CompFacturaNroComprobante.Text = "";
            cmb_CompCondCompra.Text = null;

            txt_ProdCodigo.Text = "";
            txt_ProdDescripcion.Text = "";
            txt_CompPrecioUnitProd.Text = "";
            txt_CompCantidadProd.Text = "";

            ActualizarListaCompras_porFactura();
            Deshabilitar_camposProductos();
            Habilitar_camposFactura();
            Deshabilitar_botonera();
        }
        public void Deshabilitar_botonera()
        {
            btn_CompAgregarItem.Enabled = false;
            btn_CompEliminarItem.Enabled = false;
            //btn_CompTerminar.Enabled = false;
            btn_CompEditar.Enabled = false;
        }
        public void Deshabilitar_camposFactura()
        {
            txt_ProvCUIT.Enabled = false;
            cmb_CompFacturaTipo.Enabled = false;
            txt_CompFacturaPuntoVenta.Enabled = false;
            txt_CompFacturaNroComprobante.Enabled = false;
            cmb_CompCondCompra.Enabled = false;

            txt_ProdCodigo.Select();
        }
        public void Habilitar_camposFactura()
        {
            txt_ProvCUIT.Enabled = true;
            cmb_CompFacturaTipo.Enabled = true;
            txt_CompFacturaPuntoVenta.Enabled = true;
            txt_CompFacturaNroComprobante.Enabled = true;
            cmb_CompCondCompra.Enabled = true;

            txt_ProvCUIT.Select();
        }
        public void Deshabilitar_camposProductos()
        {
            txt_ProdCodigo.Enabled = false;
            txt_CompPrecioUnitProd.Enabled = false;
            txt_CompCantidadProd.Enabled = false;

            txt_ProvCUIT.Select();
        }
        public void Habilitar_camposProductos()
        {
            txt_ProdCodigo.Enabled = true;
            txt_CompPrecioUnitProd.Enabled = true;
            txt_CompCantidadProd.Enabled = true;

            txt_ProdCodigo.Select();
        }

        public void LimpiarForm_paraNuevaCargaProductos()
        {
            txt_ProdCodigo.Text = "";
            txt_ProdDescripcion.Text = "";
            txt_CompPrecioUnitProd.Text = "";
            txt_CompCantidadProd.Text = "";

            txt_ProdCodigo.Select();
        }


        private void LimpiarForm()
        {
            if (dataGridCompras_porFacturas == true)
            {
                txt_ProvCUIT.Enabled = false;
                cmb_CompFacturaTipo.Enabled = false;
                txt_CompFacturaPuntoVenta.Enabled = false;
                txt_CompFacturaNroComprobante.Enabled = false;
                cmb_CompCondCompra.Enabled = false;

                txt_ProdCodigo.Select();
            }
            else
            {
                txt_ProdCodigo.Text = "";
                txt_ProdDescripcion.Text = "";
                txt_CompPrecioUnitProd.Text = "";
                txt_CompCantidadProd.Text = "";

                txt_ProdCodigo.Select();
            }
        }
        public void ActualizarListaCompras_porFactura()
        {
            editarEstado = false;
            //                       0          1           2         3           4           5            6           7                                      8
            string query = "SELECT factid, fechaemision, p.provid, p.cuit, p.razonsocial, tipofactura, puntoventa, numcomprobante as 'Numero de Factura', condcompra " +
                            "FROM compra c " +
                            "LEFT JOIN proveedor p ON c.provid = p.provid " +
                            "ORDER BY fechaemision ASC";
            
            MySqlConnection DB = Clases.ConexionDB.ConectarDB();

            MySqlDataAdapter DBAdaptadorComp_porFacturas = new MySqlDataAdapter(query, DB);
            DataTable TablaCompras_porFacturas = new DataTable();
            DBAdaptadorComp_porFacturas.Fill(TablaCompras_porFacturas);

            if (TablaCompras_porFacturas.Rows.Count == 0)
            {
                DBVacia = true;
                dgv_CompLista.DataSource = TablaCompras_porFacturas;
            }
            else
            {
                DBVacia = false;
                dgv_CompLista.DataSource = TablaCompras_porFacturas;
            }
        }
        public void ActualizarListaCompras_porProductos(int valorFactNro)
        {
            editarEstado = false;
            //                         0           1         2        3           4            5            6              7
            string query = "SELECT cdetalleId, c.factid, p.prodid, p.codigo, p.descripcion, cantidad, preciocompra " +
                           "FROM compraDetalle cd " +
                           "LEFT JOIN compra c ON cd.factid = c.factid " +
                           "LEFT JOIN producto p ON cd.prodid = p.prodid " +
                           "WHERE c.factid  = " + valorFactNro + " " +
                           "ORDER BY cdetalleId ASC";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();

            MySqlDataAdapter DBAdaptadorComp = new MySqlDataAdapter(query, DB);
            DataTable TablaCompras_porProductos = new DataTable();
            DBAdaptadorComp.Fill(TablaCompras_porProductos);

            if (TablaCompras_porProductos.Rows.Count == 0)
            {
                DBVacia = true;
                dgv_CompLista.DataSource = TablaCompras_porProductos;
                btn_CompTerminar.Enabled = true;
                Clases.Metodos.MensajeBaseVacia();
            }
            else
            {
                DBVacia = false;
                dgv_CompLista.DataSource = TablaCompras_porProductos;
                btn_CompTerminar.Enabled = true;
            }

            Habilitar_camposProductos();
            LimpiarForm_paraNuevaCargaProductos();
            Deshabilitar_botonera();
        }
        public void ActivarBtnAgregarItem()
        {
            if (dataGridCompras_porFacturas == true)
            {
                bool vacioItems_Factura = false;

                if (txt_ProvCUIT.Text == "") { vacioItems_Factura = true; }
                if (txt_ProvNombre.Text == "") { vacioItems_Factura = true; }
                if (cmb_CompFacturaTipo.Text == "") { vacioItems_Factura = true; }
                if (txt_CompFacturaPuntoVenta.Text == "") { vacioItems_Factura = true; }
                if (txt_CompFacturaNroComprobante.Text == "") { vacioItems_Factura = true; }
                if (cmb_CompCondCompra.Text == "") { vacioItems_Factura = true; }

                if (vacioItems_Factura == false)
                {
                    btn_CompAgregarItem.Enabled = true;
                }
                else
                {
                    btn_CompAgregarItem.Enabled = false;
                }
            }
            else
            {
                bool vacioItems_Producto = false;

                if (txt_ProdCodigo.Text == "") { vacioItems_Producto = true; }
                if (txt_ProdDescripcion.Text == "") { vacioItems_Producto = true; }
                if (txt_CompPrecioUnitProd.Text == "") { vacioItems_Producto = true; }
                if (txt_CompCantidadProd.Text == "") { vacioItems_Producto = true; }

                if (vacioItems_Producto == false)
                {
                    btn_CompAgregarItem.Enabled = true;
                }
                else
                {
                    btn_CompAgregarItem.Enabled = false;
                }
            }
        }

        /*****************************************       **********************************       *****************************************/
        /*****************************************       ***** EVENTOS DEL FORMULARIO *****       *****************************************/
        /*****************************************       **********************************       *****************************************/

        private void Frm_Compras_Load(object sender, EventArgs e)
        {
            dataGridCompras_porFacturas = true;
            LimpiarForm_paraNuevaCargaFactura();
            ActualizarListaCompras_porFactura();
            Deshabilitar_botonera();
            CargarTablas();
        }


        /****** EVENTOS DE BOTONES ******/

        private void btn_CompAgregarItem_Click(object sender, EventArgs e)
        {
            if (dataGridCompras_porFacturas == true)
            {
                dataGridCompras_porFacturas = false;

                Clases.Compras CompA = new Clases.Compras();

                CompA.CompFecha = dtp_CompFecha.Value.ToString("yyyy,MM,dd");
                CompA.CompProvID = var_ProvId;
                CompA.CompFacturaTipo = cmb_CompFacturaTipo.SelectedItem.ToString();
                CompA.CompFacturaPuntoVenta = txt_CompFacturaPuntoVenta.Text.ToString();
                CompA.CompFacturaNroComprobante = txt_CompFacturaNroComprobante.Text.ToString();
                CompA.CompCondCompra = cmb_CompCondCompra.SelectedItem.ToString();

                Clases.Metodos.GuardarCompra(CompA);

                string IdTest = "SELECT MAX(factid) as ID " +
                                "FROM compra";
                DataTable Tabla = new DataTable();
                MySqlConnection DB = Clases.ConexionDB.ConectarDB();
                MySqlDataAdapter DBAdaptadorProv = new MySqlDataAdapter(IdTest, DB);
                DBAdaptadorProv.Fill(Tabla);

                editarCompra_FactId = int.Parse(Tabla.Rows[0]["ID"].ToString());

                ActualizarListaCompras_porFactura();
                Deshabilitar_camposFactura();
                Habilitar_camposProductos();
                Deshabilitar_botonera();
            }
            else
            {
                if (editarEstado != true)
                {
                    Clases.CompraDetalle CompraDetA = new Clases.CompraDetalle();

                    CompraDetA.CompraDetFactID = editarCompra_FactId;
                    CompraDetA.CompraDetProdID = var_ProdID;
                    CompraDetA.CompraDetCantidadProd = txt_CompCantidadProd.Text.ToString();
                    CompraDetA.CompraDetPrecioUnitProd = txt_CompPrecioUnitProd.Text.ToString();

                    Clases.Metodos.GuardarCompraDetalle(CompraDetA);
                    ActualizarListaCompras_porProductos(editarCompra_FactId);
                    btn_CompTerminar.Enabled = true;
                }
                else
                {
                    Clases.CompraDetalle CompraEditDetA = new Clases.CompraDetalle();

                    CompraEditDetA.CompraDetFactID = editarCompra_FactId;
                    CompraEditDetA.CompraDetProdID = var_ProdID;
                    CompraEditDetA.CompraDetCantidadProd = txt_CompCantidadProd.Text.ToString();
                    CompraEditDetA.CompraDetPrecioUnitProd = txt_CompPrecioUnitProd.Text.ToString();

                    Clases.Metodos.EditarCompraDetalle(editarCompra_porDetelleId, CompraEditDetA);
                    ActualizarListaCompras_porProductos(editarCompra_FactId);
                    btn_CompTerminar.Enabled = true;
                }
            }
        }
        private void btn_CompEliminarItem_Click(object sender, EventArgs e)
        {
            if (DBVacia == false)
            {
                DialogResult respuesta = 0;
                respuesta = Clases.Metodos.MensajeEliminarPregunta();

                if (respuesta == DialogResult.Yes)
                {
                    int id = 0;

                    if (dataGridCompras_porFacturas == true)
                    {
                        id = int.Parse(dgv_CompLista.SelectedCells[0].Value.ToString());
                        Clases.Metodos.EliminarCompra(id);

                        LimpiarForm_paraNuevaCargaFactura();
                        Deshabilitar_botonera();
                    }
                    else
                    {
                        id = int.Parse(dgv_CompLista.SelectedCells[0].Value.ToString());
                        Clases.Metodos.EliminarCompraDetalle(id);

                        LimpiarForm_paraNuevaCargaProductos();
                        id = int.Parse(dgv_CompLista.SelectedCells[1].Value.ToString());
                        ActualizarListaCompras_porProductos(id);
                        Deshabilitar_botonera();
                        btn_CompTerminar.Enabled = true;
                    }
                }
            }
            else
            {
                Clases.Metodos.MensajeBaseVacia();
                btn_CompTerminar.Enabled = true;
            }
        }
        private void btn_CompTerminar_Click(object sender, EventArgs e)
        {
            editarCompra_FactId = 0;

            dataGridCompras_porFacturas = true;
            LimpiarForm_paraNuevaCargaFactura();

            btn_CompTerminar.Enabled = false;
        }
        private void btn_CompEditar_Click(object sender, EventArgs e)
        {
            editarEstado = true;

            if (dataGridCompras_porFacturas == true)
            {
                editarCompra_FactId = 0;
                editarCompra_FactId = int.Parse(dgv_CompLista.SelectedCells[0].Value.ToString());

                txt_ProvCUIT.Text = dgv_CompLista.SelectedCells[3].Value.ToString();
                txt_ProvNombre.Text = dgv_CompLista.SelectedCells[4].Value.ToString();
                cmb_CompFacturaTipo.Text = dgv_CompLista.SelectedCells[5].Value.ToString();
                txt_CompFacturaPuntoVenta.Text = dgv_CompLista.SelectedCells[6].Value.ToString();
                txt_CompFacturaNroComprobante.Text = dgv_CompLista.SelectedCells[7].Value.ToString();
                cmb_CompCondCompra.Text = dgv_CompLista.SelectedCells[8].Value.ToString();

                ActualizarListaCompras_porProductos(editarCompra_FactId);
                Deshabilitar_camposFactura();

                dataGridCompras_porFacturas = false;
            }
            else
            {
                editarCompra_porDetelleId = 0;
                editarCompra_porDetelleId = int.Parse(dgv_CompLista.SelectedCells[0].Value.ToString());

                txt_ProdCodigo.Text = dgv_CompLista.SelectedCells[3].Value.ToString();
                txt_ProdDescripcion.Text = dgv_CompLista.SelectedCells[4].Value.ToString();
                txt_CompCantidadProd.Text = dgv_CompLista.SelectedCells[5].Value.ToString();
                txt_CompPrecioUnitProd.Text = dgv_CompLista.SelectedCells[6].Value.ToString();
            }
        }


        /****** EVENTOS DE TEXTBOX ******/

        private void txt_ProvCUIT_TextChanged(object sender, EventArgs e)
        {
            string a = txt_ProvCUIT.Text;
            int y = 0;
            for (int x = 0; x < TablaProveedores.Rows.Count; x++)
            {
                if (a == TablaProveedores.Rows[x]["cuit"].ToString())
                    y = x;
            }
            txt_ProvNombre.Text = TablaProveedores.Rows[y]["razonsocial"].ToString();
            var_ProvId = TablaProveedores.Rows[y]["provid"].ToString();

            // BORRAR ******************** ActivarBtnAgregarItem()
            ActivarBtnAgregarItem();
        }
        private void cmb_CompFacturaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarBtnAgregarItem();
        }
        private void txt_CompFacturaPuntoVenta_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnAgregarItem();
        }
        private void txt_CompFacturaNroComprobante_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnAgregarItem();
        }
        private void cmb_CompCondCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarBtnAgregarItem();
        }
        private void txt_ProdCodigo_TextChanged(object sender, EventArgs e)
        {
            var_ProdID = "";
            string a = txt_ProdCodigo.Text;
            int y = 0;
            for (int x = 0; x < TablaProductos.Rows.Count; x++)
            {
                if (a == TablaProductos.Rows[x]["codigo"].ToString())
                    y = x;
            }
            txt_ProdDescripcion.Text = TablaProductos.Rows[y]["descripcion"].ToString();
            var_ProdID = TablaProductos.Rows[y]["prodid"].ToString();

            ActivarBtnAgregarItem();
        }
        private void txt_CompCantidadProd_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnAgregarItem();
        }
        private void txt_CompPrecioUnitProd_TextChanged(object sender, EventArgs e)
        {
            ActivarBtnAgregarItem();
        }
        private void dgv_CompLista_Click(object sender, EventArgs e)
        {
            if (DBVacia != true)
            {
                btn_CompEditar.Enabled = true;
                btn_CompEliminarItem.Enabled = true;
            }
        }
    }
}