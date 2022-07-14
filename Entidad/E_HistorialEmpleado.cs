using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_HistorialEmpleado
    {
        public string CodHistorial { get; set; }
        public string CodEmpleado { get; set; }
        public string Cargo { get; set; }
        public string Antiguedad { get; set; }

        public E_Empleados Empleados { get; set; }
        public E_HistorialEmpleado()
        {
            Empleados = new E_Empleados();
        }
    }
}
