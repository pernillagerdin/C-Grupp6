using Datalayer.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;

namespace Datalayer.Repositories {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false) {
            Database.Log = s => Debug.WriteLine(s);
        }

        public static ApplicationDbContext Create() {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); // Enable cascade delete when you remove something that requires it.
            base.OnModelCreating(modelBuilder);
        }

        // Start of DbSet(s)

        // public DbSet<{Model}> _name { get; set; }

        // End of DbSet(s)
    }
}