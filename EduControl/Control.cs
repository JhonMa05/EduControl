using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduControl
{
    class Control
    {
        public string controlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (usuario.Password == usuario.ConPassword)
                {
                    if (modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseña no coinciden";
                }
            }
            return respuesta;

        }

        public string crtlResgtroEstudiante(Estudiantes estudiante)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(estudiante.Nombre) || string.IsNullOrEmpty(estudiante.Apellido) || string.IsNullOrEmpty(estudiante.Grupo) || string.IsNullOrEmpty(estudiante.Telefono) || string.IsNullOrEmpty(estudiante.Edad) || string.IsNullOrEmpty(estudiante.Correo))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                modelo.registroEstudiante(estudiante);

            }
            return respuesta;

        }
        public string controLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.logUsuario(usuario);

                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuario.Password != password)
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                    else
                    {
                        Session.id = datosUsuario.Id;
                        Session.usuario = usuario;

                    }
                }
            }
            return respuesta;
        }
    }
 
}
