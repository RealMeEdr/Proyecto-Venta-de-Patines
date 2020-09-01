using PatinesFinal.DATOS_SQL;
using PatinesFinal.LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatinesFinal
{
    public partial class Registro_Usuario : Form
    {
        public Registro_Usuario()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 abrir = new Form1();
            abrir.Show();
            this.Close();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
            }
        }

        private void btnNuevoUs_Click(object sender, EventArgs e)
        {
            if (txtNom_usuario.Text != "")
            {
                if (txtPass.Text != "")
                {
                    insertarU();
                }
                else
                {
                    MessageBox.Show("Ingrese una Contraseña", "Sin Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Usuario", "Sin usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertarU()
        {
            Lusuarios dt = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            dt.Usuario = txtNom_usuario.Text;
            dt.Pass = txtPass.Text;
            //esta serie de comandos es para poder Convertir de formato Image parapoder procesar la imagen en la base de datos
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            dt.Icono = ms.GetBuffer();

            //Después se va a comprobar que los datos hayan sido correctos
            if (funcion.insertarU(dt))
            {
                MessageBox.Show("Usuario Registrado con Éxito \n"+"Porfavor Inicie Sesión para ingresar al Sistema.", "Acción Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 abrir = new Form1();
                abrir.Show();
                this.Close();
            }
        }
    }
}
