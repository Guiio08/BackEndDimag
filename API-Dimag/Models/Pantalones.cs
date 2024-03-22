using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class Pantalones
    {
        /*public Pantalones()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }*/
        [Key]
        [Column("id_pantalon")]
        public int IdPantalon { get; set; }
        [Column("nombrePantalon")]
        public string NombrePantalon { get; set; } = null!;
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
