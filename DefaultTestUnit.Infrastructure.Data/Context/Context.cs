using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using DefaultTestUnit.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DefaultTestUnit.Infrastructure.Data.Context
{
    public class Context : DbContext
    {
        public Context() 
            : base("DefaultTestConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Invoice> Invoices { get; set; }

    }
}
