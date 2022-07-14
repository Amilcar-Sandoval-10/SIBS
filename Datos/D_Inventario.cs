using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_Inventario
    {
        public bool Guardar(E_Inventario NuevoInventario)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "InsertarInventario";
                Comando.Parameters.AddWithValue("@ID", NuevoInventario.ID);
                Comando.Parameters.AddWithValue("@Cod_Productos", NuevoInventario.Cod_Productos);
                Comando.Parameters.AddWithValue("@Fecha_Entrada", NuevoInventario.Fecha_Entrada);
                Comando.Parameters.AddWithValue("@StockMaximo", NuevoInventario.StockMaximo);
                Comando.Parameters.AddWithValue("@StockMinimo", NuevoInventario.StockMinimo);
                Comando.Parameters.AddWithValue("@StockActual", NuevoInventario.StockActual);
                Comando.Parameters.AddWithValue("@Garantia", NuevoInventario.Garantia);
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
        public bool Modificar(E_Inventario ModificarInventario)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "ModificarInventario";
                Comando.Parameters.AddWithValue("@Cod_Inventario", ModificarInventario.Cod_Inventario);
                Comando.Parameters.AddWithValue("@Cod_Productos", ModificarInventario.Cod_Productos);
                Comando.Parameters.AddWithValue("@ID", ModificarInventario.ID);
                Comando.Parameters.AddWithValue("@Fecha_Entrada", ModificarInventario.Fecha_Entrada);
                Comando.Parameters.AddWithValue("@StockMaximo", ModificarInventario.StockMaximo);
                Comando.Parameters.AddWithValue("@StockMinimo", ModificarInventario.StockMinimo);
                Comando.Parameters.AddWithValue("@StockActual", ModificarInventario.StockActual);
                Comando.Parameters.AddWithValue("@Garantia", ModificarInventario.Garantia);
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

        public List<E_Inventario> ListaInventarioBuscar()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarInventario";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_Inventario> Lista = new List<E_Inventario>();
                while (leer.Read())
                {
                    E_Inventario FilaInventario = new E_Inventario();
                    FilaInventario.Cod_Inventario = Convert.ToInt32(leer["Cod_Inventario"].ToString());
                    FilaInventario.Codigo = leer["Codigo"].ToString();
                    FilaInventario.Cod_Productos = Convert.ToInt32(leer["Cod_Productos"].ToString());
                    FilaInventario.ID = Convert.ToInt32(leer["ID"].ToString());
                    FilaInventario.Fecha_Entrada = leer["Fecha_Entrada"].ToString();
                    FilaInventario.StockMaximo = Convert.ToInt32(leer["StockMaximo"].ToString());
                    FilaInventario.StockMinimo = Convert.ToInt32(leer["StockMinimo"].ToString());
                    FilaInventario.StockActual = Convert.ToInt32(leer["StockActual"].ToString());
                    FilaInventario.Garantia = leer["Garantia"].ToString();

                    Lista.Add(FilaInventario);
                }
                Conexion.Close();
                return Lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

         public DataTable ListaInventario()
         {
             DataTable Tabla = new DataTable();
             SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
             SqlCommand Comando = new SqlCommand();
             Comando.CommandType = CommandType.StoredProcedure;
             Comando.CommandText = "ListarProductosInventario";
             Comando.Connection = Conexion;
             Conexion.Open();
             SqlDataReader leer = Comando.ExecuteReader();
             Tabla.Load(leer);
             leer.Close();
             Conexion.Close();
             return Tabla;
         }
    }
}
