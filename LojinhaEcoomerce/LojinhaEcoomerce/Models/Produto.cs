using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojinhaEcoomerce.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public String NomeProduto { get; set; }
        public String DescricaoProduto { get; set; }
        public Double ValorProduto { get; set; }
        public Categoria Categoria { get; set; }
        [Display(Name = "Imagem do produto")]
        public String ImagemProduto { get; set; }
    }
}