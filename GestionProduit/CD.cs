using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProduit
{
    class CD : Produit
    {
        private string auteur;
        private string interp;

        
        public CD(string auteur,string interp, string nom, int prixachat, int prixvente) :base(nom,prixachat,prixvente)
        {
            this.auteur = auteur;
            this.interp = interp;

        }

        public override string ToString()
       {
           return base.ToString() + (this.auteur + " " + this.interp);
       }

    

        
            
        


    }
}
