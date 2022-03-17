using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChoixSejour.Models
{
    public class Panier
    {
       
        public int Id { get; set; }

        public virtual LigneDeProduit LigneDeProduit { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Frais de livraison")]
        public decimal Frais { get; set; }

        
        [DataType(DataType.Currency)]
        [Display(Name = "Sous-Total")]
        public decimal SommeSousTotal

        {
            get
            {
                decimal SommeSousTotal = 0;

                return SommeSousTotal + this.LigneDeProduit.SousTotal;
            }
        }
        [DataType(DataType.Currency)]
        [Display(Name = "Total")]
        public decimal Total
        {
            get
            {
                decimal Total = this.SommeSousTotal + this.Frais;
                return Total;
            }
        }

        [StringLength(03)]
        [Display(Name = "Devise")]
        public string Devise { get; set; }

    }
}
