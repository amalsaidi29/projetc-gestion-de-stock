using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfs.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public virtual ICollection<Produit> Produits { get; set; } = new List<Produit>();
    }
}


// Relation : Une catégorie peut contenir plusieurs produits
