using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoixSejour.Models
{
    public class Livraison
    {
        public int Id { get; set; }

        
        [Display(Name = "Numero envoi")]
        public int NumEnvoi { get; set; }

        [Required]
        [Display(Name = "Type de livraison")]
        public string TypeLivraison { get; set; }

        public virtual Commande Commande { get; set; }
    }
}
