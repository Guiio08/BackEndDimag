using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class TipoProducto
    {
        /*public TipoProducto()
        {
            Blusas = new HashSet<Blusas>();
            Gorros = new HashSet<Gorro>();
            Pantalones = new HashSet<Pantalones>();
            Uniformes = new HashSet<Uniforme>();
        }*/
        [Key]
        [Column("id_tipoProducto")]
        public int IdTipoProducto { get; set; }
        [Column("producto")]
        public string Producto { get; set; } = null!;

        /*[JsonIgnore]
        public virtual ICollection<Blusas> Blusas { get; set; }
        [JsonIgnore]
        public virtual ICollection<Gorro> Gorros { get; set; }
        [JsonIgnore]
        public virtual ICollection<Pantalones> Pantalones { get; set; }
        [JsonIgnore]
        public virtual ICollection<Uniforme> Uniformes { get; set; }*/
    }
}
