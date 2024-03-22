using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public class Cliente
    {
        
        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("identificacion")]
        public int? Identificacion { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; } = null!;
        [Column("direccion")]
        public string? Direccion { get; set; }
        [Column("telefono")]
        public int? Telefono { get; set; }
        [Column("correo")]
        public string? Correo { get; set; }
        [Column("id_tipoIdentificacion")]
        public int IdTipoIdentificacion { get; set; }
    }
}
