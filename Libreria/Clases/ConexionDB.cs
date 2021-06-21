using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Libreria.Clases
{
    class ConexionDB
    {
        public static MySqlConnection ConectarDB()
        {
            string server = "Server=3.14.122.10; Database=slib; Uid=dbauser; Pwd=qdsi123";
            MySqlConnection c = new MySqlConnection(server);

            try
            {
                return c;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectar a laBase de datos.\n\n" + e.Message + e.StackTrace);
                throw;
            }
        }
    }
}
