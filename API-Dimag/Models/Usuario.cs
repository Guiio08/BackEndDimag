using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Facturas = new HashSet<Factura>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Usuario1 { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Identificacion { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
