using EduControl.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduControl
{
    public partial class R_Materia : Form
    {
        public R_Materia()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtMateria.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe llenar el campo");             
            }
            else
            {
                MySqlConnection conexion = Conexion.conexion();
                conexion.Open();

                string sql = "INSERT INTO materias (nombre) VALUES(@nombre)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.ExecuteNonQuery();

                MessageBox.Show("Asignatura agregada");
                txtMateria.Text = "";
            }
        }
    }
}
