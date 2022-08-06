using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace usuarios.Datos
{
    internal  static class conexionMaestra
    {
        public static SqlConnection conexion = new SqlConnection(@"Data source = .\sqlexpress; initial catalog=USUARIOSDB; Integrated Security=true ");
        public static void abrir()
        {
            if(conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        
        public static void cerrar()
        {
            if(conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

        }
    }
}
