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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EduControl
{
    public partial class R_Notas : Form
    {
        public R_Notas()
        {
            InitializeComponent();
            llenarCbEstudiante();
            llenarCbMaterias();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un estudiante seleccionado en el ComboBox
            if (cbEstudiante.SelectedIndex != -1 || cbMateria.SelectedIndex != -1 || !string.IsNullOrWhiteSpace(txtNota.Text))
            {
                // Obtener el nombre del estudiante seleccionado
                string nombreEstudiante = cbEstudiante.SelectedItem.ToString();
                string nombreMateria = cbMateria.SelectedItem.ToString();

                // Obtener el idEstudiante asociado al nombre seleccionado
                int idEstudiante = ObtenerIdEstudiante(nombreEstudiante);
                int idMateria = ObtenerIdMateria(nombreMateria);

                // Verificar si ya existe una entrada con el mismo id_estudiante e id_materia
                if (!ExisteEntradaExistente(idEstudiante, idMateria))
                {
                    // para resgitrar la nota
                    decimal nota = decimal.TryParse(txtNota.Text, out nota) ? nota : 0;

                    // Ahora puedes utilizar el idEstudiante para realizar la operación en la otra tabla
                    // Por ejemplo, podrías insertar el idEstudiante en otra tabla
                    // Asumiendo que tienes una conexión a la base de datos llamada 'conexion' y una tabla llamada 'otra_tabla'
                    MySqlConnection conexion = Conexion.conexion();
                    string sqlInsert = "INSERT INTO notas_estudiantes_materias (id_estudiante, id_materia, puntaje) VALUES (@id_estudiante, @id_materia, @puntaje)";

                    using (MySqlCommand comandoInsert = new MySqlCommand(sqlInsert, conexion))
                    {
                        comandoInsert.Parameters.AddWithValue("@id_estudiante", idEstudiante);
                        comandoInsert.Parameters.AddWithValue("@id_materia", idMateria);
                        comandoInsert.Parameters.AddWithValue("@puntaje", nota);

                        conexion.Open();
                        comandoInsert.ExecuteNonQuery();
                        conexion.Close();
                    }

                    // Puedes agregar más lógica aquí según tus necesidades, Por ejemplo, mostrar un mensaje de éxito, limpiar el ComboBox, etc.
                    limpiar();
                    MessageBox.Show("Registrado con Éxito");
                }
                else
                {
                    MessageBox.Show("Ya existe una entrada para este estudiante y materia");
                }
            }
            else
            {
                MessageBox.Show("Seleccione y llene los campos");
            }
        }

        // Agregar el método para verificar si ya existe una entrada con el mismo id_estudiante e id_materia
        private bool ExisteEntradaExistente(int idEstudiante, int idMateria)
        {
            MySqlConnection conexion = Conexion.conexion();
            string sql = "SELECT COUNT(*) FROM notas_estudiantes_materias WHERE id_estudiante = @id_estudiante AND id_materia = @id_materia";

            using (MySqlCommand comando = new MySqlCommand(sql, conexion))
            {
                comando.Parameters.AddWithValue("@id_estudiante", idEstudiante);
                comando.Parameters.AddWithValue("@id_materia", idMateria);

                conexion.Open();
                int count = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();

                return count > 0;
            }
        }

        private int ObtenerIdEstudiante(string nombreEstudiante)
        {
            int idEstudiante = -1;

            MySqlConnection conexion = Conexion.conexion();
            string sql = "SELECT id FROM estudiantes WHERE nombre = @nombreEstudiante";

            using (MySqlCommand comando = new MySqlCommand(sql, conexion))
            {
                comando.Parameters.AddWithValue("@nombreEstudiante", nombreEstudiante);

                conexion.Open();
                object result = comando.ExecuteScalar();

                if (result != null)
                {
                    idEstudiante = Convert.ToInt32(result);
                }

                conexion.Close();
            }

            return idEstudiante;
        }
        private int ObtenerIdMateria(string nombreMateria)
        {
            int idMateria = -1;

            MySqlConnection conexion = Conexion.conexion();
            string sql = "SELECT id FROM materias WHERE nombre = @nombreMateria";

            using (MySqlCommand comando = new MySqlCommand(sql, conexion))
            {
                comando.Parameters.AddWithValue("@nombreMateria", nombreMateria);

                conexion.Open();
                object result = comando.ExecuteScalar();

                if (result != null)
                {
                    idMateria = Convert.ToInt32(result);
                }

                conexion.Close();
            }

            return idMateria;
        }

        private void llenarCbEstudiante()
        {
            cbEstudiante.Items.Clear();

            MySqlConnection conexion = Conexion.conexion();
            string sql = "SELECT id, nombre FROM estudiantes";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            conexion.Open();
            using (MySqlDataReader dr = comando.ExecuteReader())
            {
                while (dr.Read())
                {

                    int id = Convert.ToInt32(dr["id"]);                 

                    cbEstudiante.Items.Add(dr["nombre"].ToString());
                    
                }

            }
            conexion.Close();
        }

        private void llenarCbMaterias()
        {
            cbMateria.Items.Clear();

            MySqlConnection conexion = Conexion.conexion();
            string sql = "SELECT nombre FROM materias";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            conexion.Open();
            using (MySqlDataReader dr = comando.ExecuteReader())
            {
                while (dr.Read())
                {
                    cbMateria.Items.Add(dr["nombre"].ToString());
                }
            }
            conexion.Close();
   
        }
        private void limpiar()
        {
            cbEstudiante.SelectedIndex = -1; 
            cbMateria.SelectedIndex = -1;
            txtNota.Text = "";

        }
    }
}
