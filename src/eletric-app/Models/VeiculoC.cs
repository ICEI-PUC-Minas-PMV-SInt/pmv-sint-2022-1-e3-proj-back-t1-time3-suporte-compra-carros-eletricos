using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eletric_app.Models
{
    [Table("VeiculosC")]
    public class VeiculoC
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o modelo!")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o motor!")]
        public string Motor { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Obrigatório informar a média de consumo!")]
        public decimal Media { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        public DateTime Data { get; set; }
    }
}
