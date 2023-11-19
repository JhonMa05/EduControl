using EduControl.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduControl
{
    public partial class R_Notas : Form
    {
        public R_Notas()
        {
            InitializeComponent();
            //llenarCBMaterias();
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
        /*
        private void llenarCBMaterias()
        {
            
            cbMateria.Items.Clear();

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            string consulta = "select * from materias";

            MySqlDataReader reader = null;

            try
            {
                MySqlCommand command = new MySqlCommand(consulta);
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    cbMateria.Items.Add(reader.GetString("nombre"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
   
        }
        */
    }
}
