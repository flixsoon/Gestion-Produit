using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProduit
{
    class Produit
    {
        private int code;
        private string nom;
        private int prixachat;
        private int prixvente;
        static int c = 0;

        public Produit()
        {
            c++;
            code = c;
        }

        public virtual Produit( string nom, int prixachat, int prixvente)
        {
            
            this.nom = nom;
            this.prixachat = prixachat;
            this.prixvente = prixvente;
            c++;
            this.code = c;

        }

        public int Code
        {
            get { return code; }
        }


        public override string ToString()
{
 	 return (this.code + " ; " + this.nom + " ; " + this.prixachat + " ; " + this.prixvente);
}

        public override Boolean Equals(Produit pr)
        {
            if (this.nom == pr.nom)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        
           

        



    }
}
