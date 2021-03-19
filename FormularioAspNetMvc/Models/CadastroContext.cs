using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FormularioAspNetMvc.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CadastroContext : DbContext
    {
        public CadastroContext() : base("DbCadastroPessoas")
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}