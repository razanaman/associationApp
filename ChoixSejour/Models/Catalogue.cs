using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoixSejour.Models
{
    public class Catalogue
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Désignation Catalogue de produits")]
        public string DesignationCatalogue { get; set; }
        
        [Required]
        [Display(Name = "Référence Catalogue de produits")]
        public string ReferenceCatalagueProduits { get; set; }

        public virtual ICollection<Produit> Produits { get; set; }
    }
}
