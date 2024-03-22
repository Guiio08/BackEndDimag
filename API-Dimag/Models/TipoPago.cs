using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class TipoPago
    {
        public TipoPago()
        {
            Facturas = new HashSet<Factura>();
        }

        public int IdTipoPago { get; set; }
        public string TipoPago1 { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
