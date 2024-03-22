using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public class TipoIdentificacion
    {
        [Key]
        [Column("id_tipoIdentificacion")]
        public int IdTipoIdentificacion { get; set; }
        [Column("identificacion")]
        public string Identificacion { get; set; } = null!;

    }
}
