﻿namespace EduControl
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegEstudiante = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnREstudiante = new System.Windows.Forms.Button();
            this.PanelVertical = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRMateria = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRNotas = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnVerNotas = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnVerMateria = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnBoletin = new System.Windows.Forms.Button();
            this.barraTitulo.SuspendLayout();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuVertical.Controls.Add(this.PanelVertical);
            this.menuVertical.Controls.Add(this.panel1);
            this.menuVertical.Controls.Add(this.btnRegEstudiante);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 38);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(220, 612);
            this.menuVertical.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 612);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContenedor_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1272, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1241, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1210, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1241, 7);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegEstudiante
            // 
            this.btnRegEstudiante.FlatAppearance.BorderSize = 0;
            this.btnRegEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRegEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEstudiante.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnRegEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnRegEstudiante.Image")));
            this.btnRegEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegEstudiante.Location = new System.Drawing.Point(6, 138);
            this.btnRegEstudiante.Name = "btnRegEstudiante";
            this.btnRegEstudiante.Size = new System.Drawing.Size(214, 32);
            this.btnRegEstudiante.TabIndex = 1;
            this.btnRegEstudiante.Text = "R.Estudiante";
            this.btnRegEstudiante.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(3, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(3, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 2;
            // 
            // btnREstudiante
            // 
            this.btnREstudiante.FlatAppearance.BorderSize = 0;
            this.btnREstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnREstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREstudiante.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREstudiante.ForeColor = System.Drawing.Color.White;
            this.btnREstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnREstudiante.Image")));
            this.btnREstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnREstudiante.Location = new System.Drawing.Point(6, 138);
            this.btnREstudiante.Name = "btnREstudiante";
            this.btnREstudiante.Size = new System.Drawing.Size(214, 32);
            this.btnREstudiante.TabIndex = 1;
            this.btnREstudiante.Text = "R.Estudiante";
            this.btnREstudiante.UseVisualStyleBackColor = true;
            // 
            // PanelVertical
            // 
            this.PanelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelVertical.Controls.Add(this.panel8);
            this.PanelVertical.Controls.Add(this.btnBoletin);
            this.PanelVertical.Controls.Add(this.panel7);
            this.PanelVertical.Controls.Add(this.btnVerMateria);
            this.PanelVertical.Controls.Add(this.panel6);
            this.PanelVertical.Controls.Add(this.btnVerNotas);
            this.PanelVertical.Controls.Add(this.panel5);
            this.PanelVertical.Controls.Add(this.btnRNotas);
            this.PanelVertical.Controls.Add(this.panel4);
            this.PanelVertical.Controls.Add(this.btnRMateria);
            this.PanelVertical.Controls.Add(this.panel2);
            this.PanelVertical.Controls.Add(this.btnREstudiante);
            this.PanelVertical.Controls.Add(this.pictureBox2);
            this.PanelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelVertical.Location = new System.Drawing.Point(0, 0);
            this.PanelVertical.Name = "PanelVertical";
            this.PanelVertical.Size = new System.Drawing.Size(220, 612);
            this.PanelVertical.TabIndex = 3;
            this.PanelVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(3, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 4;
            // 
            // btnRMateria
            // 
            this.btnRMateria.FlatAppearance.BorderSize = 0;
            this.btnRMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRMateria.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRMateria.ForeColor = System.Drawing.Color.White;
            this.btnRMateria.Image = ((System.Drawing.Image)(resources.GetObject("btnRMateria.Image")));
            this.btnRMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRMateria.Location = new System.Drawing.Point(6, 176);
            this.btnRMateria.Name = "btnRMateria";
            this.btnRMateria.Size = new System.Drawing.Size(214, 32);
            this.btnRMateria.TabIndex = 3;
            this.btnRMateria.Text = "R.Materias";
            this.btnRMateria.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(3, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 6;
            // 
            // btnRNotas
            // 
            this.btnRNotas.FlatAppearance.BorderSize = 0;
            this.btnRNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRNotas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRNotas.ForeColor = System.Drawing.Color.White;
            this.btnRNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnRNotas.Image")));
            this.btnRNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRNotas.Location = new System.Drawing.Point(6, 214);
            this.btnRNotas.Name = "btnRNotas";
            this.btnRNotas.Size = new System.Drawing.Size(214, 32);
            this.btnRNotas.TabIndex = 5;
            this.btnRNotas.Text = "R.Notas";
            this.btnRNotas.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(3, 252);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 32);
            this.panel6.TabIndex = 8;
            // 
            // btnVerNotas
            // 
            this.btnVerNotas.FlatAppearance.BorderSize = 0;
            this.btnVerNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnVerNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerNotas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerNotas.ForeColor = System.Drawing.Color.White;
            this.btnVerNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerNotas.Image")));
            this.btnVerNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerNotas.Location = new System.Drawing.Point(6, 252);
            this.btnVerNotas.Name = "btnVerNotas";
            this.btnVerNotas.Size = new System.Drawing.Size(214, 32);
            this.btnVerNotas.TabIndex = 7;
            this.btnVerNotas.Text = "Ver Notas";
            this.btnVerNotas.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(3, 290);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 32);
            this.panel7.TabIndex = 10;
            // 
            // btnVerMateria
            // 
            this.btnVerMateria.FlatAppearance.BorderSize = 0;
            this.btnVerMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnVerMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMateria.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMateria.ForeColor = System.Drawing.Color.White;
            this.btnVerMateria.Image = ((System.Drawing.Image)(resources.GetObject("btnVerMateria.Image")));
            this.btnVerMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerMateria.Location = new System.Drawing.Point(6, 290);
            this.btnVerMateria.Name = "btnVerMateria";
            this.btnVerMateria.Size = new System.Drawing.Size(214, 32);
            this.btnVerMateria.TabIndex = 9;
            this.btnVerMateria.Text = "Ver Materia";
            this.btnVerMateria.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(3, 328);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 32);
            this.panel8.TabIndex = 12;
            // 
            // btnBoletin
            // 
            this.btnBoletin.FlatAppearance.BorderSize = 0;
            this.btnBoletin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBoletin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoletin.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletin.ForeColor = System.Drawing.Color.White;
            this.btnBoletin.Image = ((System.Drawing.Image)(resources.GetObject("btnBoletin.Image")));
            this.btnBoletin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoletin.Location = new System.Drawing.Point(6, 328);
            this.btnBoletin.Name = "btnBoletin";
            this.btnBoletin.Size = new System.Drawing.Size(214, 32);
            this.btnBoletin.TabIndex = 11;
            this.btnBoletin.Text = "Boletin";
            this.btnBoletin.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.barraTitulo.ResumeLayout(false);
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel PanelVertical;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnBoletin;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnVerMateria;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnVerNotas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRNotas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRMateria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnREstudiante;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegEstudiante;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}