using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class Uniforme
    {
       /* public Uniforme()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }
       */
        public int IdUniforme { get; set; }
        public string NombreUniforme { get; set; } = null!;
        public int IdTipoProducto { get; set; }
        public int Precio { get; set; }
        
        /*[JsonIgnore]
        public virtual TipoProducto IdTipoProductoNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }*/
    }
}
