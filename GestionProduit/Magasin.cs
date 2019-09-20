using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GestionProduit
{
    class Magasin
    {
        private string nom;
        private string adresse;

        static ArrayList listpro = new ArrayList();


        public override string ToString()
        {
            return (this.nom + " " + this.adresse + " " + listpro);
        }


        public static void AjouterProduit(Produit prd)
        {
            listpro.Add(prd);
        }

        public static void ListeLivres()
        {
            foreach(Livre l in listpro)
            {
                Console.WriteLine(l.ToString());
            }
        }
   
        public static Produit chercherproduit(string a){
            for(int i=0;i<listpro.Count;i++){
                Produit p=(Produit)listpro[i];
                if(p.Code==a){
                    return(p);
                }
                throw new Exception("le produit n'exsiste pas!!");



            }
        }
    }

