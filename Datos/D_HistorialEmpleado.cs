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
    public class D_HistorialEmpleado
    {
        public bool Guardar(E_HistorialEmpleado NuevoHistorial_Empleado)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertarHistorialEmpleado";
                command.Parameters.AddWithValue("@CodHistorial", NuevoHistorial_Empleado.CodHistorial);
                command.Parameters.AddWithValue("@Cargo", NuevoHistorial_Empleado.Cargo);
                command.Parameters.AddWithValue("@Antiguedad", NuevoHistorial_Empleado.Antiguedad);
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

        public bool Modificar(E_HistorialEmpleado ModificarHistorial_Empleado)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ModificarHistorialEmpleado";
                command.Parameters.AddWithValue("@CodHistorial", ModificarHistorial_Empleado.CodHistorial);
                command.Parameters.AddWithValue("@Cargo", ModificarHistorial_Empleado.Cargo);
                command.Parameters.AddWithValue("@Antiguedad", ModificarHistorial_Empleado.Antiguedad);
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
        public List<E_HistorialEmpleado> ListaHistorial_Empleado()
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "MostrarHistorial_Empleados";
                Comando.Connection = Conexion;
                Conexion.Open();
                SqlDataReader leer = Comando.ExecuteReader();
                List<E_HistorialEmpleado> Lista = new List<E_HistorialEmpleado>();
                while (leer.Read()) 
                {
                    E_HistorialEmpleado FilaHistorialEmpleado = new E_HistorialEmpleado();
                    FilaHistorialEmpleado.Antiguedad = leer["Antiguedad"].ToString();
                    FilaHistorialEmpleado.CodHistorial = leer["CodHistorial"].ToString();
                    FilaHistorialEmpleado.Cargo = leer["Cargo"].ToString();
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
