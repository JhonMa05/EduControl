using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduControl.Clases
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "MySQL_Jhon05";
            string bd = "edu_control";


            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; User Id=" + usuario + "; Password=" + password + "; Database=" + bd;

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (MySqlException ex) 
            { 
                Console.WriteLine("Error: "+ ex.Message);
                return null;
            }

        }
        
    }
}
