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
    public class N_Proveedores
    {
        public bool Guardar(E_Proveedores NuevoProveedor)
        {
            try
            {
                D_Proveedores DatosProveedores = new D_Proveedores();
                return DatosProveedores.Guardar(NuevoProveedor);
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
                D_Proveedores DatosProveedores = new D_Proveedores();
                return DatosProveedores.Modificar(ModificarProveedor);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable listaProveedores()
        {
            try
            {
                D_Proveedores DatosProveedores = new D_Proveedores();
                return DatosProveedores.ListaProveedor();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<E_Proveedores> ListaProveedorBuscar()
        {
            try
            {
                D_Proveedores DatosProveedor = new D_Proveedores();
                return DatosProveedor.ListaProveedorBuscar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
