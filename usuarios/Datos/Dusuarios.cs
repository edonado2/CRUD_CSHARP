using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using usuarios.Logica;
using System.Windows.Forms;
using System.Data;

namespace usuarios.Datos
{
    class Dusuarios
    {
        private SqlCommand cmd =  new SqlCommand();
        private int idusuario;
        public bool insertar(Lusuarios dt)
        {
            try
            {
                conexionMaestra.abrir();
                cmd = new SqlCommand("insertar_usuario", conexionMaestra.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USUARIO", dt.Usuario);
                cmd.Parameters.AddWithValue("@PASSWORD ", dt.Password);
                cmd.Parameters.AddWithValue("@ICON ", dt.Icon);
                cmd.Parameters.AddWithValue("@STATUS ", dt.Status);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexionMaestra.cerrar();
            }
        }
        public DataTable mostrar_usuarios()
        {
            try
            {
                conexionMaestra.abrir();
                cmd = new SqlCommand("mostrar_usuario", conexionMaestra.conexion);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool editar(Lusuarios dt)
        {
            try
            {
                conexionMaestra.abrir();
                cmd = new SqlCommand("editar_usuario", conexionMaestra.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_USUARIO", dt.Idusuario);
                cmd.Parameters.AddWithValue("@USUARIO", dt.Usuario);
                cmd.Parameters.AddWithValue("@PASSWORD ", dt.Password);
                cmd.Parameters.AddWithValue("@ICON ", dt.Icon);
                cmd.Parameters.AddWithValue("@STATUS ", dt.Status);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexionMaestra.cerrar();
            }
        }

        public bool eliminar_usuario(Lusuarios dt) {

            try { 
            conexionMaestra.abrir();
            cmd = new SqlCommand("eliminar_usuario", conexionMaestra.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_USUARIO", dt.Idusuario);
            if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexionMaestra.cerrar();
            }
    }

        public DataTable buscar(string parametros)
        {
            try
            {
                conexionMaestra.abrir();
                cmd = new SqlCommand("buscar", conexionMaestra.conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscador", parametros);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }

}
