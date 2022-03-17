using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoixSejour.Models
{
    public interface IDal: IDisposable
    {
        void DeleteCreateDatabase();
        List<Produit> ObtientTousLesProduits();

        int CreerProduit(string designation, decimal quantiteStock, string format, string reference, decimal price, string devise);

        void ModifierProduit(int id, string designation, decimal quantiteStock, string format, string reference, decimal price, string devise);
        void SupprimerProduit(int id);
        //test
    }
}
