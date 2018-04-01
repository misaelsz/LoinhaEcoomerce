using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LojinhaEcoomerce.DAL;
using LojinhaEcoomerce.Models;
using System.IO;

namespace LojinhaEcoomerce.Controllers
{
    public class ProdutoController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Produto
        public ActionResult Index()
        {
            return View(ProdutoDAO.ListarProdutos());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = ProdutoDAO.BuscarProdutoPorId(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.Categorias = new SelectList(CategoriaDAO.ListarCategorias(), "CategoriaId", "NomeCategoria");
            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProdutoId,NomeProduto,DescricaoProduto,ValorProduto")] Produto produto, int Categorias ,HttpPostedFileBase fupImagem)
        {
            ViewBag.Categorias = new SelectList(CategoriaDAO.ListarCategorias(), "CategoriaId", "NomeCategoria");
            if (ModelState.IsValid) { 
            //{
            //    if (fupImagem != null)
            //    {
            //        //Gravar imagem
            //        string caminhoUpload = Server.MapPath("~/ImagensDaLojinha/");
            //        string caminhoArquivo = Path.Combine(caminhoUpload, Path.GetFileName(fupImagem.FileName));
            //        fupImagem.SaveAs(caminhoArquivo);
            //        produto.ImagemProduto = fupImagem.FileName;


                    produto.Categoria =
                        CategoriaDAO.BuscarCategoriaPorId(Categorias);
                    ProdutoDAO.CadastrarProduto(produto);
                    return RedirectToAction("Index");
                //}
                //ModelState.AddModelError("", "Favor escolher uma imagem!");
            }
            return View(produto);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = ProdutoDAO.BuscarProdutoPorId(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProdutoId,NomeProduto,DescricaoProduto,ValorProduto")] Produto produto)
        {
            if (ModelState.IsValid)
            {

                    ProdutoDAO.EditarProduto(produto);
                    return RedirectToAction("Index");
                
                
            }
            return View(produto);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = ProdutoDAO.BuscarProdutoPorId(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = ProdutoDAO.BuscarProdutoPorId(id);
            ProdutoDAO.RemoverProduto(produto);
            return RedirectToAction("Index");
        }
    }
}
