namespace ApiDemoNegocio.Banco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pessoa")]
    public partial class Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PessoaId { get; set; }

        [StringLength(50)]
        public string NomePessoa { get; set; }

        [StringLength(50)]
        public string IdadePessoa { get; set; }
    }
}
