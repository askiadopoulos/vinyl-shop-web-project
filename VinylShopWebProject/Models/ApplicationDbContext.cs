using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // Load the related data from the corresponding database tables in memory       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<RecordLabel> RecordLabels { get; set; }
        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<ContentFile> ContentFiles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // Fluent API configurations
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Call the base method to resolve the undefined keys of the above entities:
            // EntityType => IdentityUserLogin, IdentityUserRole
            // EntitySet => IdentityUserLogin, IdentityUserRole
            base.OnModelCreating(modelBuilder);
            
            // Many-to-Many relationship between Vinyl and Format
            // It will create an associative entity (junction table)
            modelBuilder.Entity<Vinyl>()
                .HasMany(v => v.Formats)
                .WithMany(f => f.Vinyls)
                .Map(vf =>
                {
                    vf.MapLeftKey("VinylId");
                    vf.MapRightKey("FormatId");
                    vf.ToTable("FormatVinyls");
                });
                
        }

        public ApplicationDbContext()
            : base("VinylShopDBContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}