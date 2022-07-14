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
    public class D_Proveedores
    {
        public bool Guardar(E_Proveedores NuevoProveedores)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertarProveedores";
                command.Parameters.AddWithValue("@ID", NuevoProveedores.ID);
                command.Parameters.AddWithValue("@Nombre", NuevoProveedores.Nombre);
                command.Parameters.AddWithValue("@Telefono", NuevoProveedores.Telefono);
                command.Parameters.AddWithValue("@Direccion", NuevoProveedores.Direccion);
                command.Parameters.AddWithValue("@Email", NuevoProveedores.Email);
                command.Connection = Conexion;
                Conexion.Open();
                command.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Modificar(E_Proveedores ModificarProveedor)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ModificarProveedores";
                command.Parameters.AddWithValue("@Cod_Proveedor", ModificarProveedor.Cod_Proveedor);
                command.Parameters.AddWithValue("@Nombre", ModificarProveedor.Nombre);
                command.Parameters.AddWithValue("@Telefono", ModificarProveedor.Telefono);
                command.Parameters.AddWithValue("@Direccion", ModificarProveedor.Direccion);
                command.Parameters.AddWithValue("@Email", ModificarProveedor.Email);
                command.Connection = Conexion;
                Conexion.Open();
                command.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ListaProveedor()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarProveedor";
            Comando.Connection = Conexion;
            Conexion.Open();
            SqlDataReader leer = Comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            Conexion.Close();
            return Tabla;
        }
        public List<E_Proveedores> ListaProveedorBuscar()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarProveedorBuscar";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Proveedores> Lista = new List<E_Proveedores>();
                while (leer.Read())
                {
                    E_Proveedores FilaProveedor = new E_Proveedores();
                    FilaProveedor.Cod_Proveedor = Convert.ToInt32(leer["Cod_Proveedor"].ToString());
                    FilaProveedor.Codigo = leer["Codigo"].ToString();
                    FilaProveedor.Nombre = leer["Nombre"].ToString();
                    FilaProveedor.ID = Convert.ToInt32(leer["ID"].ToString());
                    FilaProveedor.Telefono = Convert.ToInt32(leer["Telefono"].ToString());
                    FilaProveedor.Direccion = leer["Direccion"].ToString();
                    FilaProveedor.Email = leer["Email"].ToString();
                    Lista.Add(FilaProveedor);
                }
                Conexion.Close();
                return Lista;

            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
