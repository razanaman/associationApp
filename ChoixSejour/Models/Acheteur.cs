using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoixSejour.Models
{
    public class Acheteur 
    {
        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        [Display(Name = "Civilité ")]
        public string Civilite { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date de naissance")]
        public DateTime DateNaissance { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Adresse")]
        public string Adresse { get; set; }

        [Required]
        [StringLength(08)]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public virtual Panier Panier { get; set; }
        // test fix
        public virtual ICollection<Commande> Commandes { get; set; }
    }
}
