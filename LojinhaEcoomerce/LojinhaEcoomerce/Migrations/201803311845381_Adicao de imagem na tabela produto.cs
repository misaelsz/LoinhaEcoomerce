namespace LojinhaEcoomerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adicaodeimagemnatabelaproduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "ImagemProduto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "ImagemProduto");
        }
    }
}
