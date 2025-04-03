using System;
using System.Collections.Generic;

namespace projetfs.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public int ClientId { get; set; }  // Clé étrangère
        public DateTime Date { get; set; }
        public decimal Total { get; set; }

        // Propriété de navigation (un seul côté de la relation)
        public virtual Client Client { get; set; }

        // Collection des produits commandés
        public virtual ICollection<CommandeProduit> CommandeProduits { get; set; } = new List<CommandeProduit>();
    }
}