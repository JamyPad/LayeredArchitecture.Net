using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades_POCO
{
    public class TarjetaCortes
    {
        public int TarjetaCorteId { get; set; }
        public string TarjetaId { get; set; }
        public decimal SaldoAlCorte { get; set; }
        public virtual Tarjeta Tarjeta { get; set; }
    }


}
