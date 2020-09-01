using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatinesFinal
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void lblCerrarApp_Click(object sender, EventArgs e)
        {
            DialogResult decision;
            decision = MessageBox.Show("¿De verdad quiere Cerrar el porgrama?", "Cerrar Aplicación", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if(decision == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult decision;
            decision = MessageBox.Show("¿En verdad desea Cerrar su sesión?","Cerrar Sesión",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(decision == DialogResult.Yes)
            {
                Form1 abrir = new Form1();
                abrir.Show();
                this.Close();
            }
            
        }
    }
}
