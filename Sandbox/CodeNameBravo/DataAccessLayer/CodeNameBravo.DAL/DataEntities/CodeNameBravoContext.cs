using CodeNameBravo.Domain.Entities.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNameBravo.Web.DAL.DataEntities
{
    public class CodeNameBravoContext : DbContext
    {
        public CodeNameBravoContext()
            : base("BravoConnection")
        {
            var _ = typeof(System.Data.Entity.SqlServer.SqlProviderServices);

        }

        public DbSet<Store> Stores { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("Store");

            modelBuilder.Entity<Store>()
                .Property(s => s.Name)
                .HasMaxLength(50);
        }


    }
}
