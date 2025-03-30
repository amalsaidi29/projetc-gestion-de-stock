using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfs
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        // Relation : Une catégorie peut contenir plusieurs produits
        public ICollection<Produit> Produits { get; set; } = new List<Produit>();
    }

}
