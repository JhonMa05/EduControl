using EduControl.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduControl
{
    class Modelo
    {
        public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios (usuario, password) VALUES(@usuario, @password)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

            //
        }
        public int registroEstudiante(Estudiantes estudiante) 
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            string sql = "INSERT INTO estudiantes (nombre, apellido, grupo, telefono, edad, correo) VALUES(@nombre, @apellido, @grupo, @telefono, @edad, @correo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", estudiante.Nombre);
            comando.Parameters.AddWithValue("@apellido", estudiante.Apellido);
            comando.Parameters.AddWithValue("@grupo", estudiante.Grupo);
            comando.Parameters.AddWithValue("@telefono", estudiante.Telefono);
            comando.Parameters.AddWithValue("@edad", estudiante.Edad);
            comando.Parameters.AddWithValue("@correo", estudiante.Correo);

            int resul = comando.ExecuteNonQuery();

            return resul;

            //
        }
        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            string sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuarios logUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            string sql = "SELECT id, password FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Password = reader["password"].ToString();

            }
            return usr;
        }
    }
}
