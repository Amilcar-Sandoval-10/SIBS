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
    public class D_Empleados
    {
       public bool Guardar(E_Empleados NuevoEmpleado)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertarEmpleados";
                command.Parameters.AddWithValue("@Nombre", NuevoEmpleado.Nombre);
                command.Parameters.AddWithValue("@Apellidos", NuevoEmpleado.Apellidos);
                command.Parameters.AddWithValue("@Cargo", NuevoEmpleado.Cargo);
                command.Parameters.AddWithValue("@INSS", NuevoEmpleado.INSS);
                command.Parameters.AddWithValue("@FechaNac", NuevoEmpleado.FechaNac);
                command.Parameters.AddWithValue("@Genero", NuevoEmpleado.Genero);
                command.Parameters.AddWithValue("@Direccion", NuevoEmpleado.Direccion);
                command.Parameters.AddWithValue("@Telefono", NuevoEmpleado.Telefono);
                command.Parameters.AddWithValue("@EstadoCivil", NuevoEmpleado.Estado_Civil);
                command.Parameters.AddWithValue("@Email", NuevoEmpleado.Correo);
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
        public bool Modificar(E_Empleados ModificarEmpleado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ModificarEmpleados";
                command.Parameters.AddWithValue("@CodEmpleado", ModificarEmpleado.CodEmpleado);
                command.Parameters.AddWithValue("@Nombre", ModificarEmpleado.Nombre);
                command.Parameters.AddWithValue("@Apellidos", ModificarEmpleado.Apellidos);
                command.Parameters.AddWithValue("@Cargo", ModificarEmpleado.Cargo);
                command.Parameters.AddWithValue("@INSS", ModificarEmpleado.INSS);
                command.Parameters.AddWithValue("@FechaNac", ModificarEmpleado.FechaNac);
                command.Parameters.AddWithValue("@Genero", ModificarEmpleado.Genero);
                command.Parameters.AddWithValue("@Direccion", ModificarEmpleado.Direccion);
                command.Parameters.AddWithValue("@Telefono", ModificarEmpleado.Telefono);
                command.Parameters.AddWithValue("@EstadoCivil", ModificarEmpleado.Estado_Civil);
                command.Parameters.AddWithValue("@Email", ModificarEmpleado.Correo);
                command.Connection = conexion;
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<E_Empleados> ListaEmpleadoBuscar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "MostrarEmpleadoB";
                command.Connection = conexion;
                conexion.Open();
                SqlDataReader leer = command.ExecuteReader();
                List<E_Empleados> Lista = new List<E_Empleados>();
                while (leer.Read())
                {
                    E_Empleados filaEmpleado = new E_Empleados();
                    filaEmpleado.CodEmpleado =Convert.ToInt32(leer["CodEmpleado"].ToString());
                    filaEmpleado.Codigo = leer["Codigo"].ToString();
                    filaEmpleado.Nombre = leer["Nombre"].ToString();
                    filaEmpleado.Apellidos = leer["Apellidos"].ToString();
                    filaEmpleado.Cargo = leer["Cargo"].ToString();
                    filaEmpleado.INSS = Convert.ToInt32(leer["INSS"].ToString());
                    filaEmpleado.FechaNac = leer["FechaNac"].ToString();
                    filaEmpleado.Genero = leer["Genero"].ToString();
                    filaEmpleado.Direccion = leer["Direccion"].ToString();
                    filaEmpleado.Telefono = Convert.ToInt32(leer["Telefono"].ToString());
                    filaEmpleado.Estado_Civil = leer["EstadoCivil"].ToString();
                    filaEmpleado.Correo = leer["Email"].ToString();
                    Lista.Add(filaEmpleado);
                }
                conexion.Close();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ListaEmpleado()
        {
            DataTable Tabla = new DataTable();
            SqlConnection Conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand Comando = new SqlCommand();
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "MostrarEmpleado";
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
