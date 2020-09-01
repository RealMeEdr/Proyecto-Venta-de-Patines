using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatinesFinal.LOGICA
{
    class Lempresas
    {
        private int idempresa;
        private string nombre;
        private string pais;
        private byte[] icono;
        private string modelo_patin;
        private string publico;

        //Se deben declarar los Métodos. publicos
        public int Idempresa
        {
            get { return idempresa; }
            set { idempresa = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public byte[] Icono
        {
            get { return icono; }
            set { icono = value; }
        }

        public string Modelo
        {
            get { return modelo_patin; }
            set { modelo_patin = value; }
        }

        public string Publico
        {
            get { return publico; }
            set { publico = value; }
        }
        public Lempresas()
        {

        }
        //private int idusuario;
        //private string usuarios;
        //private string pass;
        //private byte[] icono;
        //private string estado;
        public Lempresas(int idempresa, string nombre, string pais, byte[] icono,string modelo_patin, string publico)
        {
            Idempresa = idempresa;
            Nombre = nombre;
            Pais = pais;
            Icono = icono;
            Modelo = modelo_patin;
            Publico = publico;
        }
    }
}
