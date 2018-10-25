using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    class Jeu
    {
        #region Attributs
        private int id;
        private string nom;
        private int id_cat;
        private int annee;
        private string studio;
        private List<string> plateforme = new List<string>();
        #endregion

        #region Methode get/set
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Id_cat
        {
            get { return id_cat; }
            set { id_cat = value; }
        }

        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public string Studio
        {
            get { return studio; }
            set { studio = value; }
        }

        public List<string> Plateforme
        {
            get { return plateforme; }
        }
        #endregion

        #region Methode
        public bool AjouterPlateformeList(string plateforme)
        {
            if (plateforme == null)
            {
                throw new Exception();
            }
            else
            {
                Plateforme.Add(plateforme);
                return true;
            }
        }
        #endregion

        #region Constructor
        public Jeu(int id, string nom, int id_cat, int annee, string studio)
        {
            Id = id;
            Nom = nom;
            Id_cat = id_cat;
            Annee = annee;
            Studio = studio;
        }
        #endregion
    }
}
