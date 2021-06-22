using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Libreria.Clases
{
    class MetodosDB
    {

        /*****************************************       **********************************       *****************************************/
        /*****************************************       ******* MÉTODOS DE LA CLASE ******       *****************************************/
        /*****************************************       **********************************       *****************************************/

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
