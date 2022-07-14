using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
namespace Negocio
{
    public class NClientes
    {
        public bool Guardar(E_Clientes NuevoCliente)
        {
            try
            {
                D_Clientes DatosCliente = new D_Clientes();
                return DatosCliente.Guardar(NuevoCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Modificar(E_Clientes ModificarCliente)
        {
            try
            {
                D_Clientes DatosCliente = new D_Clientes();
                return DatosCliente.Modificar(ModificarCliente);
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
                D_Clientes DatosClientes = new D_Clientes();
                return DatosClientes.ListaClientes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
