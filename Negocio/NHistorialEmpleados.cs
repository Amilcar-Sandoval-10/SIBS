using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;  

namespace Negocio
{
    public class NHistorialEmpleados
    {
        public bool Guardar(E_HistorialEmpleado NuevoHistorialEmpleados)
        {
            try
            {
                D_HistorialEmpleado DatosHistorialEmpleado = new D_HistorialEmpleado();
                return DatosHistorialEmpleado.Guardar(NuevoHistorialEmpleados);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Modificar(E_HistorialEmpleado ModificarHistorialEmpleados)
        {
            try
            {
                D_HistorialEmpleado DatosHistorialEmpleado = new D_HistorialEmpleado();
                return DatosHistorialEmpleado.Modificar(ModificarHistorialEmpleados);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<E_HistorialEmpleado> ListaHistorialEmpleados()
        {
            try
            {
                D_HistorialEmpleado DatosHistorialEmpleado = new D_HistorialEmpleado();
                return DatosHistorialEmpleado.ListaHistorial_Empleado();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
