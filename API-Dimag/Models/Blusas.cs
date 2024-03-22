using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class Blusas
    {
        /*public Blusas()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }*/
        [Key]
        [Column("id_blusa")]
        public int id_Blusa { get; set; }
        [Column("nombreBlusa")]
        public string NombreBlusa { get; set; } = null!;
        [Column("id_tipoProducto")]
        public int IdTipoProducto { get; set; }
        [Column("precio")]
        public int Precio { get; set; }
        /*
        [JsonIgnore]
        public virtual TipoProducto IdTipoProductoNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }*/
    }
}
