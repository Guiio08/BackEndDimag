using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class Factura
    {
        /*public Factura()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }*/

        public int IdFactura { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoPago { get; set; }
        /*
        [JsonIgnore]
        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual TipoPago IdTipoPagoNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }*/
    }
}
