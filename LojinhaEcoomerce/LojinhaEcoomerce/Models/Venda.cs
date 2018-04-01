using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojinhaEcoomerce.Models
{
    [Table("Vendas")]
    public class Venda
    {
        [Key]
        public int VendaId { get; set; }
        public List<int> ItemVendaIds { get; set; }
        public DateTime DataVenda { get; set; }
        public Double TotalDaVenda { get; set; }
    }
}