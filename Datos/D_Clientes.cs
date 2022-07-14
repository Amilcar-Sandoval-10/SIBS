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
    public class D_Clientes
    {
        public bool Guardar(E_Clientes NuevoCliente)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "InsertarCliente";
                Comando.Parameters.AddWithValue("@Nombre", NuevoCliente.Nombre);
                Comando.Parameters.AddWithValue("@Apellidos", NuevoCliente.Apellidos);
                Comando.Parameters.AddWithValue("@Cedula", NuevoCliente.Cedula);
                Comando.Parameters.AddWithValue("@FechaNac", NuevoCliente.Fecha_Nac);
                Comando.Parameters.AddWithValue("@Genero", NuevoCliente.Genero);
                Comando.Parameters.AddWithValue("@Direccion", NuevoCliente.Direccion);
                Comando.Parameters.AddWithValue("@Telefono", NuevoCliente.Telefono);
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
        public bool Modificar(E_Clientes ModificarClientes)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "ModificarClientes";
                Comando.Parameters.AddWithValue("@Id_Cliente", ModificarClientes.Id_Cliente);
                Comando.Parameters.AddWithValue("@Nombre", ModificarClientes.Nombre);
                Comando.Parameters.AddWithValue("@Apellidos", ModificarClientes.Apellidos);
                Comando.Parameters.AddWithValue("@Cedula", ModificarClientes.Cedula);
                Comando.Parameters.AddWithValue("@FechaNac", ModificarClientes.Fecha_Nac);
                Comando.Parameters.AddWithValue("@Genero", ModificarClientes.Genero);
                Comando.Parameters.AddWithValue("@Direccion", ModificarClientes.Direccion);
                Comando.Parameters.AddWithValue("@Telefono", ModificarClientes.Telefono);
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
        
        public List<E_Clientes> ListaClientes()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarClientes";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Clientes> Lista = new List<E_Clientes>();
                while(leer.Read())
                {
                    E_Clientes FilaClientes = new E_Clientes();
                    FilaClientes.Id_Cliente = Convert.ToInt32(leer["Id_Cliente"].ToString());
                    FilaClientes.Codigo= leer["Codigo"].ToString();
                    FilaClientes.Nombre = leer["Nombre"].ToString();
                    FilaClientes.Apellidos = leer["Apellidos"].ToString();
                    FilaClientes.Cedula = leer["Cedula"].ToString();
                    FilaClientes.Fecha_Nac = leer["FechaNac"].ToString();
                    FilaClientes.Genero = leer["Genero"].ToString();
                    FilaClientes.Direccion = leer["Direccion"].ToString();
                    FilaClientes.Telefono = Convert.ToInt32(leer["Telefono"].ToString());
                    Lista.Add(FilaClientes);
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
