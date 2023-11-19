using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduControl
{
    class Estudiantes
    {
        int id;
        string nombre, apellido, grupo, telefono, edad, correo;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
