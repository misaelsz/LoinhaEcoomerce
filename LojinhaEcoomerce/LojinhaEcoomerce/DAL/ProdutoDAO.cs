using LojinhaEcoomerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojinhaEcoomerce.DAL
{
    public class ProdutoDAO
    {
        private static Contexto ctx = Singleton.Instance.Contexto;

        public static List<Produto> ListarProdutos()
        {
            return ctx.Produtos.ToList();
        }
        public static Produto BuscarProdutoPorId(int? id)
        {
            return ctx.Produtos.Find(id);
        }
        public static void CadastrarProduto(Produto produto)
        {
            ctx.Produtos.Add(produto);
            ctx.SaveChanges();
        }
        public static void EditarProduto(Produto produto)
        {
            ctx.Entry(produto).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoverProduto(Produto produto)
        {
            ctx.Produtos.Remove(produto);
            ctx.SaveChanges();
        }
    }
}