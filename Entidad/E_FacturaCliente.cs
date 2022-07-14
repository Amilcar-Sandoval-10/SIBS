using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_FacturaCliente
    {
        public int Id_Factura { get; set; }
        public string Codigo { get; set; }
        public int Id_Cliente { get; set; }
        public int Cod_Productos { get; set; }
        public int Cod_Inventario { get; set; }
        public int ID { get; set; }
        public int Cod_Empleado { get; set; }
        public string FormaPago { get; set; }
        public int Cantidad { get; set; }
        public double Subtotal { get; set; }
        public double IVA { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }

    }
}
