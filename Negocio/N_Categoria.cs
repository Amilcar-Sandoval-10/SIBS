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
    public class N_Categoria
    {
        public DataTable ListaCategoria()//Toma nota, es mas facil asi
        {
            try
            {
                D_Categoria DCategoria = new D_Categoria();
                return DCategoria.ListarCategoria();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
