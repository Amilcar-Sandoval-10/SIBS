using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Inventario
    {
        public int Cod_Inventario { get; set; }
        public string Codigo { get; set; }
        public int ID { get; set; }
        public int Cod_Productos { get; set; }
        public string Fecha_Entrada { get; set; }
        public int StockMaximo { get; set; }
        public int StockMinimo { get; set; }
        public int StockActual { get; set; }
        public string Garantia { get; set; }

    }
}
