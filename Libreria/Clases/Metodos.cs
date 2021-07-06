using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Libreria.Clases
{
    class Metodos
    {

        /******* MÉTODOS de BOTONES ******** Form_AdminUsr ********/

        public static void GuardarUsuario(Usuarios u)
        {
            int retornoComando = 0;
            string query = "INSERT INTO usuario (nombre,cuenta,pw,tipo,estado) " +
                           "VALUES ( '" + u.UserNombre + "','" + u.UserCuenta + "','" + u.UserContraseña + "'," +
                                    "'" + u.UserTipoCuenta + "','" + u.UserEstadoCuenta + "')";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeGuardarExito();
            }
            else
            {
                MensajeGuardarError();
            }
        }
        public static void EditarUsuario(int valorid, Usuarios u)
        {
            int retornoComando = 0;
            string query = "UPDATE usuario " +
                           "SET nombre ='"+ u.UserNombre + "',cuenta ='" + u.UserCuenta + "',pw ='" + u.UserContraseña + "'," +
                                "tipo ='" + u.UserTipoCuenta + "',estado ='" + u.UserEstadoCuenta + "' " +
                           "WHERE userid = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEditarExito();
            }
            else
            {
                MensajeEditarError();
            }
        }
        public static void EliminarUsuario(int valorid)
        {
            int retornoComando = 0;
            string query = "DELETE FROM usuario " +
                           "WHERE userid = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEliminarExito();
            }
            else
            {
                MensajeEliminarError();
            }
        }

        /******* MÉTODOS de BOTONES ******** Form_Clientes ********/

        public static void GuardarCliente(Clientes c)
        {
            int retornoComando = 0;
            string query = "INSERT INTO cliente (cuit,nombre,domicilio,ingresosbrutos,condicioniva,contacto,email,telefono,telefono2) " +
                           "VALUES ( '" + c.ClieCUIT + "','" + c.ClieNombreRS + "','" + c.ClieDomicilio + "','" + c.ClieIngBrutos + "','" + c.ClieCondicionIVA + "'," +
                                    "'" + c.ClieContacto + "','" + c.ClieMail + "','" + c.ClieTelefono1 + "','" + c.ClieTelefono2 + "')";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeGuardarExito();
            }
            else
            {
                MensajeGuardarError();
            }
        }
        public static void EditarCliente(int valorid, Clientes c)
        {
            int retornoComando = 0;
            string query = "UPDATE cliente " +
                            "SET cuit ='" + c.ClieCUIT + "',nombre ='" + c.ClieNombreRS + "',domicilio ='" + c.ClieDomicilio + "'," +
                                "ingresosbrutos ='" + c.ClieIngBrutos + "',condicioniva ='" + c.ClieCondicionIVA + "',contacto ='" + c.ClieContacto + "'," +
                                "email ='" + c.ClieMail + "',telefono ='" + c.ClieTelefono1 + "',telefono2 ='" + c.ClieTelefono2 + "' " +
                            "WHERE cliid = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEditarExito();
            }
            else
            {
                MensajeEditarError();
            }
        }
        public static void EliminarCliente(int valorid)
        {
            int retornoComando = 0;
            string query = "DELETE FROM cliente " +
                           "WHERE cliid = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEliminarExito();
            }
            else
            {
                MensajeEliminarError();
            }
        }

        /******* MÉTODOS de BOTONES ******** Form_Proveedores ********/

        public static void GuardarProveedor(Proveedores p)
        {
            int retornoComando = 0;
            string query = "INSERT INTO proveedor " +
                           "(cuit,razonsocial,domicilio,ingresosbrutos,condicioniva,condicionventa,nombrecontacto,email,telefono,telefono2) " +
                           "VALUES ( '" + p.ProvCUIT + "','" + p.ProvNombreRS + "','" + p.ProvDomicilio + "','" + p.ProvIngBrutos + "','" + p.ProvCondicionIVA + "'," +
                                    "'" + p.ProvCondicionVenta + "','" + p.ProvContacto + "','" + p.ProvMail + "','" + p.ProvTelefono1 + "','" + p.ProvTelefono2 + "')";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeGuardarExito();
            }
            else
            {
                MensajeGuardarError();
            }
        }
        public static void EditarProveedor(int valorid, Proveedores p)
        {
            int retornoComando = 0;
            string query = "UPDATE proveedor " +
                           "SET cuit ='" + p.ProvCUIT + "',razonsocial ='" + p.ProvNombreRS + "',domicilio ='" + p.ProvDomicilio + "'," + "ingresosbrutos ='" + p.ProvIngBrutos + "',condicioniva ='" + p.ProvCondicionIVA + "'," +
                           "condicionventa ='" + p.ProvCondicionVenta + "',nombrecontacto ='" + p.ProvContacto + "'," +
                           "email ='" + p.ProvMail + "',telefono ='" + p.ProvTelefono1 + "',telefono2 ='" + p.ProvTelefono2 + "' " +
                           "WHERE provid = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEditarExito();
            }
            else
            {
                MensajeEditarError();
            }
        }
        public static void EliminarProveedor(int valorid)
        {
            int retornoComando = 0;
            string query = "DELETE FROM proveedor " +
                           "WHERE provid = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEliminarExito();
            }
            else
            {
                MensajeEliminarError();
            }
        }

        /******* MÉTODOS de BOTONES ******** Form_Productos ********/

        public static void GuardarProducto(Productos p)
        {
            int retornoComando = 0;
            string query = "INSERT INTO producto " +
                           "(codigo,descripcion,stock,unidadmedida,margen) " +
                           "VALUES ( '" + p.ProdCodigo + "','" + p.ProdDescripcion + "','" + p.ProdCantStock + "','" + p.ProdUnidadMed + "','" + p.ProMargenGanancia + "')";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeGuardarExito();
            }
            else
            {
                MensajeGuardarError();
            }
        }
        public static void EditarProducto(int valorid, Productos p)
        {
            int retornoComando = 0;
            string query = "UPDATE producto " +
                           "SET codigo ='" + p.ProdCodigo + "',descripcion ='" + p.ProdDescripcion + "',stock ='" + p.ProdCantStock + "'," + "unidadmedida ='" + p.ProdUnidadMed + "',margen ='" + p.ProMargenGanancia + "' " +
                           "WHERE prodid = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEditarExito();
            }
            else
            {
                MensajeEditarError();
            }
        }
        public static void EliminarProducto(int valorid)
        {
            int retornoComando = 0;
            string query = "DELETE FROM producto " +
                           "WHERE prodid = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEliminarExito();
            }
            else
            {
                MensajeEliminarError();
            }
        }

        /******* MÉTODOS de BOTONES ******** Form_Compras ********/
        public static void GuardarCompra(Compras c)
        {
            int retornoComando = 0;

            string query = "INSERT INTO compra " +
                           "(fechaemision, provid, tipofactura, puntoventa, numcomprobante, condcompra)" +
                           "VALUES ( '" + c.CompFecha + "','" + c.CompProvID + "','" + c.CompFacturaTipo + "','" + c.CompFacturaPuntoVenta + "','" + c.CompFacturaNroComprobante + "','" + c.CompCondCompra + "')";
            
            //string query = "INSERT INTO compra " +
            //               "(provid, tipofactura, puntoventa, numcomprobante, condcompra, prodid, cantidad, preciocompra)" + 
            //               "VALUES ( '" + c.CompProvID + "','" + c.CompFacturaTipo + "','" + c.CompFacturaPuntoVenta + "','" + c.CompFacturaNroComprobante + "','" + c.CompCondCompra + "'," +
            //                        "'" + c.CompProdID + "','" + c.CompCantidadProd + "','" + c.CompPrecioUnitProd + "')"; 

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeGuardarExito();
            }
            else
            {
                MensajeGuardarError();
            }
        }
        public static void EditarCompra(int valorid, Compras c)
        {
            int retornoComando = 0;

            string query = "UPDATE compra " +
                           "SET fechaemision ='" + c.CompFacturaTipo + "', provid, tipofactura, puntoventa, numcomprobante, condcompra)" +
                           "VALUES ( '" + c.CompProvID + "','" + c.CompFacturaTipo + "','" + c.CompFacturaPuntoVenta + "','" + c.CompFacturaNroComprobante + "','" + c.CompCondCompra + "')";

            //string query = "UPDATE compra " +
            //               "SET tipofactura ='" + c.CompFacturaTipo + "',puntoventa ='" + c.CompFacturaPuntoVenta + "',numcomprobante ='" + c.CompFacturaNroComprobante + "'," +
            //               "condcompra ='" + c.CompCondCompra + "',prodid ='" + c.CompProdID + "',cantidad ='" + c.CompCantidadProd + "',preciocompra ='" + c.CompPrecioUnitProd + "' " +
            //               "WHERE CONCAT(puntoventa, numcomprobante) = '" + valorid + "'";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEditarExito();
            }
            else
            {
                MensajeEditarError();
            }
        }

        public static void GuardarCompraDetalle(CompraDetalle cd)
        {
            int retornoComando = 0;

            string query = "INSERT INTO compraDetalle " +
                           "(factid, prodid, cantidad, preciocompra)" +
                           "VALUES ( '" + cd.CompraDetFactID + "','" + cd.CompraDetProdID + "','" + cd.CompraDetCantidadProd + "','" + cd.CompraDetPrecioUnitProd + "')";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeGuardarExito();
            }
            else
            {
                MensajeGuardarError();
            }
        }
        public static void EditarCompraDetalle(int valorid, CompraDetalle cd)
        {
            int retornoComando = 0;

            string query = "UPDATE compraDetalle " +
                           "SET factid ='" + cd.CompraDetFactID + "', prodid = '" + cd.CompraDetProdID + "', cantidad = '" + cd.CompraDetCantidadProd + "', preciocompra = '" + cd.CompraDetPrecioUnitProd + "' " +
                           "WHERE cdetalleId = " + valorid + "";

            //string query = "UPDATE compra " +
            //               "SET tipofactura ='" + c.CompFacturaTipo + "',puntoventa ='" + c.CompFacturaPuntoVenta + "',numcomprobante ='" + c.CompFacturaNroComprobante + "'," +
            //               "condcompra ='" + c.CompCondCompra + "',prodid ='" + c.CompProdID + "',cantidad ='" + c.CompCantidadProd + "',preciocompra ='" + c.CompPrecioUnitProd + "' " +
            //               "WHERE CONCAT(puntoventa, numcomprobante) = '" + valorid + "'";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEditarExito();
            }
            else
            {
                MensajeEditarError();
            }
        }
        public static void EliminarCompra(int valorid)
        {
            int retornoComando = 0;
            string query = "DELETE FROM compra " +
                           "WHERE factid = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEliminarExito();
            }
            else
            {
                MensajeEliminarError();
            }
        }
        public static void EliminarCompraDetalle(int valorid)
        {
            int retornoComando = 0;
            string query = "DELETE FROM compraDetalle " +
                           "WHERE cdetalleId = " + valorid + "";

            MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            DB.Open();
            MySqlCommand comando = new MySqlCommand(query, DB);
            retornoComando = comando.ExecuteNonQuery();
            DB.Close();

            if (retornoComando > 0)
            {
                MensajeEliminarExito();
            }
            else
            {
                MensajeEliminarError();
            }

            //try
            //{
            //    MySqlConnection DB = Clases.ConexionDB.ConectarDB();
            //    DB.Open();
            //    MySqlCommand comando = new MySqlCommand(query, DB);
            //    retornoComando = comando.ExecuteNonQuery();
            //    DB.Close();
            //}
            //catch
            //{
            //    MensajeEliminarError();
            //}
        }



        /******* MÉTODOS para MENSAJES GENÉRICOS para eventos de botones *******/

        public static DialogResult MensajeEliminarPregunta()
        {
            DialogResult a = MessageBox.Show("¿Está seguro que desea eliminar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return a;
        }
        public static DialogResult MensajeEliminarExito()
        {
            DialogResult a = MessageBox.Show("El usuario se eliminó con éxito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return a;
        }
        public static DialogResult MensajeEliminarError()
        {
            DialogResult a = MessageBox.Show("Ocurrió un error al eliminar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return a;
        }

        public static DialogResult MensajeGuardarExito()
        {
            DialogResult a = MessageBox.Show("El registro se guardó con éxito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return a;
        }
        public static DialogResult MensajeGuardarError()
        {
            DialogResult a = MessageBox.Show("Ocurrió un error al guardar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return a;
        }

        public static DialogResult MensajeEditarExito()
        {
            DialogResult a = MessageBox.Show("El registro se editó con éxito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return a;
        }
        public static DialogResult MensajeEditarError()
        {
            DialogResult a = MessageBox.Show("Ocurrió un error al editar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return a;
        }

        /******* MÉTODOS para MENSAJES por ALERTAS *******/

        public static DialogResult MensajeBaseVacia()
        {
            DialogResult a = MessageBox.Show("La base de datos está vacía.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return a;
        }
        public static DialogResult MensajeValoresIguales()
        {
            DialogResult a = MessageBox.Show("No se ha realizado ningún cambio.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return a;
        }
    }
}
