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
    public class N_Producto
    {
        public DataTable ListaPro( )
        {
            try
            {
                D_Productos DProd = new D_Productos();
                return DProd.ListarProduc();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
