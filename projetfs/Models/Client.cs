using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace projetfs.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nom { get; set; }

        [Required]
        [StringLength(100)]
        public required string Prenom { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public required string Email { get; set; }

        [StringLength(20)]
        public string? Telephone { get; set; }

        [StringLength(200)]
        public string? Adresse { get; set; }

        [StringLength(50)]
        public string? Pays { get; set; }

        [StringLength(50)]
        public string? Ville { get; set; }

        public virtual ICollection<Commande>? Commandes { get; set; }
    }

    
}