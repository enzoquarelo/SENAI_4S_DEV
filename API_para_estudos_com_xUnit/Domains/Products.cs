using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_para_estudos_com_xUnit.Domains
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public Guid IdProduto { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        public string? Nome { get; set; }

        [Column(TypeName = "DECIMAL")]
        [Required(ErrorMessage = "O preço do produto é obrigatório!")]
        public decimal? Preco { get; set; }

    }
}
