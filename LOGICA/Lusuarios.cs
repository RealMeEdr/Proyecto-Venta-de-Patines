using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatinesFinal.LOGICA
{
    class Lusuarios
    {

        private int idusuario;
        private string usuarios;
        private string pass;
        private byte[] icono;

        //Se deben declarar los Métodos. publicos
        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public string Usuario
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public byte[] Icono
        {
            get { return icono; }
            set { icono = value; }
        }
        public Lusuarios()
        {

        }
        //private int idusuario;
        //private string usuarios;
        //private string pass;
        //private byte[] icono;
        //private string estado;
        public Lusuarios(int idusuario, string usuarios, string pass, byte[] icono)
        {
            Idusuario = idusuario;
            Usuario = usuarios;
            Pass = pass;
            Icono = icono;
        }
    }
}

