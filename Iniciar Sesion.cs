using PatinesFinal.DATOS_SQL;
using PatinesFinal.LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatinesFinal
{
    public partial class Form1 : Form
    {
        sqlConnectionLibrary.SQLConnection conn;
        public Form1()
        {
            
            
            InitializeComponent();
            conn = new sqlConnectionLibrary.SQLConnection();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            confirm abrir = new confirm();
            abrir.Show();
            this.Hide();
        }

        private void btnconexion_Click(object sender, EventArgs e)
        {
            if (conn.TestConnection())
            {
                MessageBox.Show("No hay problemas con la conexión");
            }
            else
            {
                MessageBox.Show("Hubo un error con la conexión");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
           if(txtUsuario.Text != "")
            {
                if(txtContra.Text != "")
                {
                    ConfirUsuario();
                    
                }
                else
                {
                    MessageBox.Show("Debe indicar una contraseña");
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar un Usuario");
            }
        }

        private void ConfirUsuario()
        {
            Lusuarios dt = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            dt.Usuario = txtUsuario.Text;
            dt.Pass = txtContra.Text;
            if (funcion.comprobarSesion(dt))
            {
                MessageBox.Show("Usuario correcto, bienvenido: " + txtUsuario.Text, "Usuario registrado", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Menu_Principal abrir = new Menu_Principal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto/Contraseña incorrecta", "Usuario no registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
