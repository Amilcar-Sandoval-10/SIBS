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
    public class D_FacturaCliente
    {
        public bool Guardar(E_FacturaCliente NuevaFacturaCliente)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "InsertarFactura";
                Comando.Parameters.AddWithValue("@Id_Cliente", NuevaFacturaCliente.Id_Cliente);
                Comando.Parameters.AddWithValue("@Cod_Productos", NuevaFacturaCliente.Cod_Productos);
                Comando.Parameters.AddWithValue("@CodEmpleado", NuevaFacturaCliente.Cod_Empleado);
                Comando.Parameters.AddWithValue("@ID", NuevaFacturaCliente.ID);
                Comando.Parameters.AddWithValue("Cod_Inventario", NuevaFacturaCliente.Cod_Inventario);
                Comando.Parameters.AddWithValue("@FormaPago", NuevaFacturaCliente.FormaPago);
                Comando.Parameters.AddWithValue("@Cantidad", NuevaFacturaCliente.Cantidad);
                Comando.Parameters.AddWithValue("@Subtotal", NuevaFacturaCliente.Subtotal);
                Comando.Parameters.AddWithValue("@IVA", NuevaFacturaCliente.IVA);
                Comando.Parameters.AddWithValue("@Descuento", NuevaFacturaCliente.Descuento);
                Comando.Parameters.AddWithValue("@Total", NuevaFacturaCliente.Total);
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
        public bool Quitar(E_FacturaCliente QuitarFacturaCliente)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "QuitarVenta";
                Comando.Parameters.AddWithValue("@Id_Factura", QuitarFacturaCliente.Id_Factura);
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
        public DataTable MostrarVenta()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarVenta";
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
