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
        public static void AgregarUsuario(Usuarios u)
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
                MessageBox.Show("El usuario se guardó con éxito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("El usuario se editó con éxito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al editar usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("El usuario se eliminó con éxito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al eliminar usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static DialogResult MensajeDeseaEliminar()
        {
            DialogResult a = MessageBox.Show("¿Está seguro que desea eliminar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return a;
        }
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
