using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoixSejour.Models
{
    public class BddContext : DbContext
    {
        //public DbSet<Personne> Personnes { get; set; }
        public DbSet<Acheteur> Acheteurs { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<LigneDeProduit> LigneDeProduits { get; set; }
        public DbSet<Panier> Paniers { get; set; }

        public DbSet<Commande> Commandes { get; set; }

        public DbSet<Catalogue> Catalogues { get; set; }

        public DbSet<Livraison> Livraisons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=RRRRR;database=Boutique");
        }
    }
}
