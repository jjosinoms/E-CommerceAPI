using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace ApiProdutos.Services.Models
{
    public class ProdutosPutModel
    {
        [Required(ErrorMessage = "Por favor, informe o Id do produto desejado.")]
        public Guid IdProduto { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string? Nome { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a descrição do produto.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Por favor, informe a preço do produto.")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade do produto.")]
        public int? Quantidade { get; set; }

        [Required(ErrorMessage = "Por favor, informe o id da categoria.")]
        public Guid? IdCategoria { get; set; }
    }
}
