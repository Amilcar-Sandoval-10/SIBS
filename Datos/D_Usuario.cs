using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;


namespace Datos
{
    public class D_Usuario
    {
        public bool Guardar(E_Usuario NuevoUsuario)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "InsertarUsuario";
                Comando.Parameters.AddWithValue("@CodEmpleado", NuevoUsuario.CodEmpleado);
                Comando.Parameters.AddWithValue("@Usuario", NuevoUsuario.Usuario);
                Comando.Parameters.AddWithValue("@Contraseña", NuevoUsuario.Contraseña);
                Comando.Parameters.AddWithValue("@Tipo_Usuario", NuevoUsuario.Tipo_Usuario);
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Modificar(E_Usuario ModificarNuevoUsuario)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "ModificarUsuario";
                Comando.Parameters.AddWithValue("@Id_Usuario", ModificarNuevoUsuario.Id_Usuario);
                Comando.Parameters.AddWithValue("@CodEmpleado", ModificarNuevoUsuario.CodEmpleado);
                Comando.Parameters.AddWithValue("@Usuario", ModificarNuevoUsuario.Usuario);
                Comando.Parameters.AddWithValue("@Contraseña", ModificarNuevoUsuario.Contraseña);
                Comando.Parameters.AddWithValue("@Tipo_Usuario", ModificarNuevoUsuario.Tipo_Usuario);
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ListaUsuario()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarUsuario";
            Comando.Connection = Conexion;
            Conexion.Open();
            SqlDataReader leer = Comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            Conexion.Close();
            return Tabla;
        }
        public List<E_Usuario> ListaUsuarioBuscar()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarUsuario";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Usuario> Lista = new List<E_Usuario>();
                while (leer.Read())
                {
                    E_Usuario FilaUsuario = new E_Usuario();
                    FilaUsuario.Id_Usuario = Convert.ToInt32(leer["Id_Usuario"].ToString());
                    FilaUsuario.CodEmpleado = Convert.ToInt32(leer["CodEmpleado"].ToString());
                    FilaUsuario.Usuario = leer["Usuario"].ToString();
                    FilaUsuario.Contraseña = leer["Contraseña"].ToString();
                    FilaUsuario.Tipo_Usuario = leer["Tipo_Usuario"].ToString();
                    Lista.Add(FilaUsuario);
                }
                Conexion.Close();
                return Lista;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Acceso(E_Usuario AccesoUsuario)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "AccesoUsuario";
                Comando.Parameters.AddWithValue("@Usuario", AccesoUsuario.Usuario);
                Comando.Parameters.AddWithValue("@Contraseña", AccesoUsuario.Contraseña);
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                if(leer.HasRows)
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

                throw ex;
            }

        }
    }
}
