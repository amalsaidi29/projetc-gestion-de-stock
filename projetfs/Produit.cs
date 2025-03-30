using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfs
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public int Stock { get; set; }

        // Clé étrangère vers Categorie
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }

        // Relation : Un produit peut être dans plusieurs commandes
        public ICollection<CommandeProduit> CommandeProduits { get; set; } = new List<CommandeProduit>();
    }

}
