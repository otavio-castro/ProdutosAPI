using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otavio_877229_persistencia_dados.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [MaxLength(50)]
        public string? Codigo { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [MaxLength(500)]
        public string? Descricao { get; set; }

        [Required]
        public int QuantidadeEstoque { get; set; }

        [Range(0, 5)]
        public double Avaliacao { get; set; }

        [MaxLength(50)]
        public string? Categoria { get; set; }
    }
}
