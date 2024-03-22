using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class Delantales
    {
        /*public Delantales()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }*/

        public int IdDelantal { get; set; }
        public string NombreDelantal { get; set; } = null!;
        public int IdTipoProducto { get; set; }
        public int Precio { get; set; }
        /*
        [JsonIgnore]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }*/
    }
}
