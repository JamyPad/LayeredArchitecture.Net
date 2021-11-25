using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades_POCO
{
    public class Cuenta
    {
        public string CuentaId { get; set; }
        public string AsociadoId { get; set; }
        public string TipoCuenta { get; set; }
        public string TarjetaId { get; set; }
        public decimal Saldo { get; set; }
        public decimal Anticipo { get; set; }



    }
}
