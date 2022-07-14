using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Data;

namespace Negocio
{
    public class NInventario
    {
        public bool Guardar(E_Inventario NuevoInventario)
        {
            try
            {
                D_Inventario DatosInventario = new D_Inventario();
                return DatosInventario.Guardar(NuevoInventario);
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
                D_Inventario DatosInventario = new D_Inventario();
                return DatosInventario.Modificar(ModificarInventario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ListaInventario()
        {
            try
            {
                D_Inventario DatosInventario = new D_Inventario();
                return DatosInventario.ListaInventario();
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
                D_Inventario DatosinventarioB = new D_Inventario();
                return DatosinventarioB.ListaInventarioBuscar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       

    }
}
