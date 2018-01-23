using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.EF
{
    public class AfspraakContext : DbContext
    {
        public AfspraakContext() : base("AfspraakContext")
        {

        }

        public DbSet<Afspraak> Afspraken { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}