using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidad;
using Datos;

namespace Negocio
{
    public class N_FacturaCliente
    {
        public bool Guardar(E_FacturaCliente NuevaFacturaCliente)
        {
            try
            {
                D_FacturaCliente DatosFacturaCliente = new D_FacturaCliente();
                return DatosFacturaCliente.Guardar(NuevaFacturaCliente);
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
                D_FacturaCliente DatosFacturaCliente = new D_FacturaCliente();
                return DatosFacturaCliente.Quitar(QuitarFacturaCliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ListaFacCliente()
        {
            try
            {
                D_FacturaCliente DatosFacCliente = new D_FacturaCliente();
                return DatosFacCliente.MostrarVenta();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
    
}
