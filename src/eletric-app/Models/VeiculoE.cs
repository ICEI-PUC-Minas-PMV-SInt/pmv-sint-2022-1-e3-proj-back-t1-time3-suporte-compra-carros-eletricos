using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eletric_app.Models
{
    [Table("VeiculosE")]
    public class VeiculoE
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o modelo!")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o motor!")]
        public string Motor { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Obrigatório informar a capacidade da bateria!")]
        public decimal Capacidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Obrigatório informar a autonomia!")]
        public decimal Autonomia { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Obrigatório informar a eficiência!")]
        public decimal Eficiencia { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        public DateTime Data { get; set; }
    }
}
