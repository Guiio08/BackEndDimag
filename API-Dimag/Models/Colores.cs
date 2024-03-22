using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class Colores
    {
        /*public Colores()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }*/

        public int IdColor { get; set; }
        public string Color { get; set; } = null!;
        /*
        [JsonIgnore]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }*/
    }
}
