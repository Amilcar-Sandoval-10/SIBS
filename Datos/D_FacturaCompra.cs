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
    public class D_FacturaCompra
    {
        public bool Guardar(E_FacturaCompra NuevaFactCompra)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "InsertarFactura_Compra";
                comando.Parameters.AddWithValue("@Cod_Proveedor", NuevaFactCompra.Cod_Proveedor);
                comando.Parameters.AddWithValue("@Cod_Productos", NuevaFactCompra.Cod_Productos);
                comando.Parameters.AddWithValue("@Cod_Inventario", NuevaFactCompra.Cod_Inventario);
                comando.Parameters.AddWithValue("@ID", NuevaFactCompra.ID);                     
                comando.Parameters.AddWithValue("@FormaPago", NuevaFactCompra.FormaPago);
                comando.Parameters.AddWithValue("@Cantidad", NuevaFactCompra.Cantidad);
                comando.Parameters.AddWithValue("@Subtotal", NuevaFactCompra.Subtotal);
                comando.Parameters.AddWithValue("@IVA", NuevaFactCompra.IVA);
                comando.Parameters.AddWithValue("@Descuento", NuevaFactCompra.Descuento);
                comando.Parameters.AddWithValue("@Total", NuevaFactCompra.Total);
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Modificar(E_FacturaCompra ModificarFactCompra)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ModificarFactura_Compra";
                comando.Parameters.AddWithValue("@ID_Compras", ModificarFactCompra.Id_Compras);
                comando.Parameters.AddWithValue("@Descuento ", ModificarFactCompra.FormaPago);
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable MostrarFac_Comp()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarFac_Comp";
            Comando.Connection = Conexion;
            Conexion.Open();
            SqlDataReader leer = Comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            Conexion.Close();
            return Tabla;
        }
        public bool Quitar(E_FacturaCompra QuitarFacturaCompra)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "QuitarCompra";
                Comando.Parameters.AddWithValue("@ID_Compras", QuitarFacturaCompra.Id_Compras);
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
    }
}
