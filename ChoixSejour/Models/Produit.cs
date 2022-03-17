using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoixSejour.Models
{
    public class Produit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Designation ")]
        public string Designation { get; set; }

        [Required]
        [Display(Name = "Quantité disponible")]
        public decimal QuantiteStock { get; set; }

        [Required]
        [Display(Name = "Format")]
        public string Format { get; set; }

        [Required]
        [Display(Name = "Référence")]
        public string Reference { get; set; }

        [Display(Name = "Description du produit")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Prix Unitaire")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Devise")]
        public string Devise { get; set; }
    }
}
