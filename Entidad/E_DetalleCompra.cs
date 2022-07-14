using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_DetalleCompra
    {
        public string Id_Detalle { get; set; }
        public string Id_Compras { get; set; }
        public string Cod_Producto { get; set; }
        public int Cantidad { get; set; }
        public double MontoantesIVA { get; set; }
        public double IVA { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        public E_FacturaCompra FacturaCompra { get; set; }
        
        
      
    }
}
