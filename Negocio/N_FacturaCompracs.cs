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
    public class N_FacturaCompracs
    {
        public bool Guardar(E_FacturaCompra NuevaFacturaCompra)
        {
            try
            {
                D_FacturaCompra DatosFacturaCompra = new D_FacturaCompra();
                return DatosFacturaCompra.Guardar(NuevaFacturaCompra);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ListaFacturaCompra()
        {
            try
            {
                D_FacturaCompra DatosFacturaCompra = new D_FacturaCompra();
                return DatosFacturaCompra.MostrarFac_Comp();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Quitar(E_FacturaCompra QuitarFacturaCompra)
        {
            try
            {
                D_FacturaCompra DatosFacturaCompra = new D_FacturaCompra();
                return DatosFacturaCompra.Quitar(QuitarFacturaCompra);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
