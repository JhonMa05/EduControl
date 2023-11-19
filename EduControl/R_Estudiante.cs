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
    public partial class R_Estudiante : Form
    {
        public R_Estudiante()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.Nombre = txtNombre.Text;
            estudiante.Apellido = txtApellido.Text;
            estudiante.Grupo = txtGrupo.Text;
            estudiante.Telefono = txtTelefono.Text;
            estudiante.Edad = txtEdad.Text;
            estudiante.Correo = txtCorreo.Text;

            try
            {
                Control control = new Control();
                string respuesta = control.crtlResgtroEstudiante(estudiante);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Estudiante registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            limpiar();
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtGrupo.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            txtCorreo.Text = "";

        }//metodo para limpiar los cuadros de textos
    }
}
