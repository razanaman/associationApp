using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChoixSejour.Models
{
    public class Commande
    {
        public int Id { get; set; }

        
        [Display(Name = "Numero Commande")]
        public int NumCommande { get; set; }

        public virtual Acheteur Acheteur { get; set; }

        public virtual Panier Panier { get; set; }

        //public string Statut { get; set; }

        //public string NumEnvoi { get; set; }
    }
}
