using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISCADE
{
    public class Transaccion
    {
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public int IdMoneda { get; set; }
        public string TipoTransaccion { get; set; }
        public decimal Monto { get; set; }
        public decimal TasaCambioAplicada { get; set; }
        public decimal TotalLocal { get; set; }
        public string FormaPago { get; set; }
        public string Observaciones { get; set; }
    }

}
