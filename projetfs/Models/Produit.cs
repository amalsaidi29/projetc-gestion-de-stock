using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetfs.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public decimal Prix { get; set; }
        public int Stock { get; set; }
        public byte[] ImageData { get; set; }
        public int CategorieId { get; set; }
        public virtual Categorie? Categorie { get; set; }
        public virtual ICollection<CommandeProduit> CommandeProduits { get; set; } = new List<CommandeProduit>();

        [NotMapped]
        public string PrixFormate => Prix.ToString("0.00") + " €";
    }
}