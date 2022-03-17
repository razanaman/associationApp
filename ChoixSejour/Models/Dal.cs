using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoixSejour.Models
{
    public class Dal: IDal
    {
        private BddContext _bddContext;
        public Dal()
        {
            _bddContext = new BddContext();
        }

        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }

        public List<Produit> ObtientTousLesProduits()
        {
            return _bddContext.Produits.ToList();
        }

        public int CreerProduit(string designation, decimal quantiteStock, string format, string reference, decimal price, string devise)
        {
            Produit produit = new Produit { Designation = designation, QuantiteStock = quantiteStock, Format = format, Reference = reference, Price = price, Devise = devise };
            _bddContext.Produits.Add(produit);
            _bddContext.SaveChanges();
            return produit.Id;
        }

        public void ModifierProduit(int id, string designation, decimal quantiteStock, string format, string reference, decimal price, string devise)
        {
            Produit produit = _bddContext.Produits.Find(id);

            if (produit != null)
            {
                produit.Designation = designation;
                produit.QuantiteStock = quantiteStock;
                produit.Format = format;
                produit.Reference = reference;
                produit.Price = price;
                produit.Devise = devise;
                _bddContext.SaveChanges();
            }
        }
        public void SupprimerProduit(int id)
        {
            Produit produit = _bddContext.Produits.Find(id);
            if (produit != null)
            {
                _bddContext.Produits.Remove(produit);
                _bddContext.SaveChanges();
            }
        }
        public void Dispose()
        {
            _bddContext.Dispose();
        }
    }
}
