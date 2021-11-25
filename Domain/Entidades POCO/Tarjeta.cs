using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades_POCO
{
    public class Tarjeta
    {
        public string TarjetaId { get; set; }
        public string AsociadoId { get; set; }
        public string TipoTarjeta { get; set; }
        public int PIN { get; set; }

        public virtual TarjetaCortes TarjetaCortes { get; set; }
    }
}
