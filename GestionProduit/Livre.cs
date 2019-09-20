using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProduit
{
    class Livre : Produit
    {
        private string auteur;
        private string editeur;
        private int nbrpages;

        public Livre(string auteur, string editeur, int nbrpages, string nom, int prixachat, int prixvente)
            : base(nom, prixachat, prixvente)

            {
                this.auteur = auteur;
                this.editeur = editeur;
                this.nbrpages = nbrpages;
            }



        public override string ToString()
        {
            return base.ToString()+(this.auteur+" "+this.editeur+" "+this.nbrpages);
        }

        public double CalculerCout()
        {
            return (nbrpages * (1.95));
        }

    }
}


