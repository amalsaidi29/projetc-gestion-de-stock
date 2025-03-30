using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfs
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }

        // Clé étrangère vers Client
        public int ClientId { get; set; }
        public Client Client { get; set; }

        // Relation : Une commande contient plusieurs produits
        public ICollection<CommandeProduit> CommandeProduits { get; set; } = new List<CommandeProduit>();
    }
}

