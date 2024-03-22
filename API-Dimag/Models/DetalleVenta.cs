using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Dimag.Models
{
    public class DetalleVenta
    {
        [Key]
        [Column("id_detalle")]
        public int Id_Detalle { get; set; }
        [Column("id_factura")]
        public int Id_Factura { get; set; }
        [Column("cantidad")]
        public int Cantidad { get; set; }
        [Column("id_color")]
        public int? Id_Color { get; set; }
        [Column("id_blusa")]
        public int? Id_Blusa { get; set; }
        [Column("id_uniforme")]
        public int? Id_Uniforme { get; set; }
        [Column("id_pantalon")]
        public int? Id_Pantalon { get; set; }
        [Column("id_gorro")]
        public int? Id_Gorro { get; set; }
        [Column("id_delantal")]
        public int? Id_Delantal { get; set; }
        [Column("valorTotalDetalle")]
        public int Valor_Total_Detalle { get; set; }
        [Column("observacion")]
        public string? Observacion { get; set; }
        [Column("tallaPantalon")]
        public string? TallaPantalon { get; set; }
        [Column("tallaBlusa")]
        public string? TallaBlusa { get; set; }
        [Column("id_generoPrenda")]
        public int? Id_Genero_Prenda { get; set; }
        
    }
}
