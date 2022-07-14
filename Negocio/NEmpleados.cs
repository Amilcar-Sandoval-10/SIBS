using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data;

namespace Negocio
{
    public class NEmpleados
    {
        public bool Guardar(E_Empleados NuevoEmpleados)
        {
            try
            {
                D_Empleados DatosEmpleados = new D_Empleados();
                return DatosEmpleados.Guardar(NuevoEmpleados);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Modificar(E_Empleados ModificarEmpleados)
        {
            try
            {
                D_Empleados DatosEmpleados = new D_Empleados();
                return DatosEmpleados.Modificar(ModificarEmpleados);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ListaEmpleados()
        {
            try
            {
                D_Empleados DatosEmpleados = new D_Empleados();
                return DatosEmpleados.ListaEmpleado();
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
                D_Empleados d_Empleados = new D_Empleados();
                return d_Empleados.ListaEmpleadoBuscar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
