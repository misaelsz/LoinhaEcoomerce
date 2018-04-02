namespace LojinhaEcoomerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adicaodetabelasdomeuprojetinhonobancolojinha : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        NomeCategoria = c.String(),
                        DescricaoCategoria = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.ItemVenda",
                c => new
                    {
                        ItemVendaId = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Produto_ProdutoId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemVendaId)
                .ForeignKey("dbo.Produtos", t => t.Produto_ProdutoId)
                .Index(t => t.Produto_ProdutoId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        NomeProduto = c.String(),
                        DescricaoProduto = c.String(),
                        ValorProduto = c.Double(nullable: false),
                        ImagemProduto = c.String(),
                        Categoria_CategoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Categorias", t => t.Categoria_CategoriaId)
                .Index(t => t.Categoria_CategoriaId);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        VendaId = c.Int(nullable: false, identity: true),
                        DataVenda = c.DateTime(nullable: false),
                        TotalDaVenda = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.VendaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemVenda", "Produto_ProdutoId", "dbo.Produtos");
            DropForeignKey("dbo.Produtos", "Categoria_CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "Categoria_CategoriaId" });
            DropIndex("dbo.ItemVenda", new[] { "Produto_ProdutoId" });
            DropTable("dbo.Vendas");
            DropTable("dbo.Produtos");
            DropTable("dbo.ItemVenda");
            DropTable("dbo.Categorias");
        }
    }
}
