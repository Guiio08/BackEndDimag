using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class Gorro
    {
        /*public Gorro()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }*/

        public int IdGorro { get; set; }
        public string NombreGorro { get; set; } = null!;
        public int IdTipoProducto { get; set; }
        public int Precio { get; set; }

        /*[JsonIgnore]
        public virtual TipoProducto IdTipoProductoNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }*/
    }
}
