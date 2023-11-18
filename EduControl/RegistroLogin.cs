using EduControl.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduControl
{
    public partial class RegistroLogin : Form
    {
        public RegistroLogin()
        {
            InitializeComponent();
        }
        //Para poder arrastrar el cuadro de LOGIN
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);

        //Evento para cerrar el cuadro de LOGIN
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento para minimizar el cuadro de LOGIN
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Evento para cuando el mouse este dentro de la caja de texto
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }
        //Evento para cuando el mouse sale del cuadro de texto
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }
        //Evento para cuando el mouse este dentro de la caja de texto
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        //Evento para cuando el mouse sale del cuadro de texto
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
        //Evento para cuando el mouse este dentro de la caja de texto
        private void txtConfirmacionPass_Enter(object sender, EventArgs e)
        {
            if (txtConfirmacionPass.Text == "CONFIRMACION")
            {
                txtConfirmacionPass.Text = "";
                txtConfirmacionPass.ForeColor = Color.DimGray;
                txtConfirmacionPass.UseSystemPasswordChar = true;
            }
        }
        //Evento para cuando el mouse sale del cuadro de texto
        private void txtConfirmacionPass_Leave(object sender, EventArgs e)
        {
            if (txtConfirmacionPass.Text == "")
            {
                txtConfirmacionPass.Text = "CONFIRMACION";
                txtConfirmacionPass.ForeColor = Color.DimGray;
                txtConfirmacionPass.UseSystemPasswordChar = false;
            }
        }
        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Usuario = txtUsuario.Text;
            usuario.Password = txtContraseña.Text;
            usuario.ConPassword = txtConfirmacionPass.Text;

            try
            {
                Control control = new Control();
                string respuesta = control.controlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            limpiar();
        }
        private void RegistroLogin_Load(object sender, EventArgs e)
        {
        }

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {
        }

        private void RegistroLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtConfirmacionPass.Text = "";
            
        }//metodo para limpiar los cuadros de textos

        private void picBoxVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
