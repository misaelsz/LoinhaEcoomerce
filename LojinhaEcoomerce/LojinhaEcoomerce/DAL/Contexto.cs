using LojinhaEcoomerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojinhaEcoomerce.DAL
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("name=ApiDemoEntity")
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}