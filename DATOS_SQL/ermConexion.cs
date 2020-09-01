using sqlConnectionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PatinesFinal.DATOS_SQL
{
    internal static class ermConexion
    {
         public static SqlConnection ErmConexion = new SqlConnection("Data Source=eryzeni5;Initial Catalog=PATINESFINAL;Integrated Security=True");

        public static void abrir()
        {
            if(ErmConexion.State == ConnectionState.Closed)
            {
                ErmConexion.Open();
            }
            else
            {
                MessageBox.Show("No se pudo abrir la conexión");
            }
        }

        public static void cerrar()
        {
            if(ErmConexion.State == ConnectionState.Open)
            {
                ErmConexion.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error para cerrar la conexión");
            }
        }
    }
}
