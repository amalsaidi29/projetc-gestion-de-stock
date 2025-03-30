using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfs
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        // Relation : Un client peut avoir plusieurs commandes
        public ICollection<Commande> Commandes { get; set; } = new List<Commande>();
    }

}
