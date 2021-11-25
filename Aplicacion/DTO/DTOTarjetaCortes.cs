using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTO
{
    public class DTOTarjetaCortes
    {
        public int TarjetaCorteId { get; set; }
        public string TarjetaId { get; set; }
        public decimal SaldoAlCorte { get; set; }
    }
}
