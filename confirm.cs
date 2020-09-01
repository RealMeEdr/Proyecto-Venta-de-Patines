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
    public partial class confirm : Form
    {
        public confirm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtconfirm.Text == "Admin")
            {
                MessageBox.Show("Contraseña correcta, redirigiendolo al formulario de nuevo registro","contraseña Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registro_Usuario abrir = new Registro_Usuario();
                abrir.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
