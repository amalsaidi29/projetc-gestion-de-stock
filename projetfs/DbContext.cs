using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace projetfs
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<CommandeProduit> CommandesProduits { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=GestionStockDB;Trusted_Connection=True;TrustServerCertificate=True;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Définition de la clé composite pour la table intermédiaire
            modelBuilder.Entity<CommandeProduit>()
                .HasKey(cp => new { cp.CommandeId, cp.ProduitId });

            // Définition des relations entre les entités
            modelBuilder.Entity<Commande>()
                .HasOne(c => c.Client)
                .WithMany(c => c.Commandes)
                .HasForeignKey(c => c.ClientId);

            base.OnModelCreating(modelBuilder); // IMPORTANT : Appeler la méthode de base
        }
    }
}
