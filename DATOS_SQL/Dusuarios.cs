using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PatinesFinal.LOGICA;
using sqlConnectionLibrary;
using System.Windows.Forms;

namespace PatinesFinal.DATOS_SQL
{
    class Dusuarios
    {
        sqlConnectionLibrary.SQLConnection conn = new sqlConnectionLibrary.SQLConnection();
        private SqlCommand cmd = new SqlCommand();
        private int idusuario;

        public bool insertarU(Lusuarios dt)
        {
            try
            {
                ermConexion.abrir();
                cmd = new SqlCommand("NUEV_USUARIO", ermConexion.ErmConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom_usuario",dt.Usuario);
                cmd.Parameters.AddWithValue("@pass",dt.Pass);
                cmd.Parameters.AddWithValue("@icono",dt.Icono);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }catch(Exception m)
            {
                MessageBox.Show("Hubo un error en:  \n" + m.Message);
                return false;
            }
            finally
            {
                ermConexion.cerrar();
            }
        }

        public bool comprobarSesion(Lusuarios dt)
        {
            try
            {
                ermConexion.abrir();
            cmd = new SqlCommand("INICIO_SESION",ermConexion.ErmConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom_usuario", dt.Usuario);
            cmd.Parameters.AddWithValue("@pass", dt.Pass);
            SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    return true;
                }
               else
            {
                    MessageBox.Show("No existe un Usuario con ese nombre");
                    return false;
            }
            }catch (Exception m)
            {
                MessageBox.Show("Error en: " +m.Message);
                return false;
            }
            finally
            {
                ermConexion.cerrar();
            }
        }


    }
}
