using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChoixSejour.Models
{
    public class LigneDeProduit
    {
        public int Id { get; set; }
        public virtual Produit Produit { get; set; }

        [Required]
        public decimal Quantite { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Sous-Total")]
       
        public decimal SousTotal
        {
            get
            {
                decimal SousTotal = this.Produit.Price * Quantite;
                return SousTotal;
            }
        }

        [StringLength(03)]
        [Display(Name = "Devise")]
        public string Devise { get; set; }
    }
}
