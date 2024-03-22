using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class Genero
    {
        /*public Genero()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }*/

        public int IdGenero { get; set; }
        public string Genero1 { get; set; } = null!;

        /*[JsonIgnore]
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }*/
    }
}
