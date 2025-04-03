using Microsoft.EntityFrameworkCore;
using projetfs.Models;

namespace projetfs.DAL
{
    public class ApplicationDbContext : DbContext
    {
        // Tables existantes (clients)
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }

        // Nouvelles tables (produits)
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<CommandeProduit> CommandeProduits { get; set; }

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=dbclients.db");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CommandeProduit>()
                .HasKey(cp => new { cp.CommandeId, cp.ProduitId });

            modelBuilder.Entity<CommandeProduit>()
                .HasOne(cp => cp.Commande)
                .WithMany(c => c.CommandeProduits)
                .HasForeignKey(cp => cp.CommandeId);

            modelBuilder.Entity<CommandeProduit>()
                .HasOne(cp => cp.Produit)
                .WithMany(p => p.CommandeProduits)
                .HasForeignKey(cp => cp.ProduitId);
        }


    }
}