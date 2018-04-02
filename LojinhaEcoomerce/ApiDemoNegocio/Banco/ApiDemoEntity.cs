namespace ApiDemoNegocio.Banco
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApiDemoEntity : DbContext
    {
        public ApiDemoEntity()
            : base("name=ApiDemoEntity")
        {
        }

        public virtual DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .Property(e => e.NomePessoa)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.IdadePessoa)
                .IsUnicode(false);
        }
    }
}
