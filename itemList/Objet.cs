using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    public class Objet
    {
        #region Attributs
        private int id;
        private string nom;
        private string description;
        private int id_jeu;
        private int id_cat_objet;
        #endregion

        #region Méthode get/set
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

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Id_jeu
        {
            get { return id_jeu; }
            set { id_jeu = value; }
        }

        public int Id_cat_objet
        {
            get { return id_cat_objet; }
            set { id_cat_objet = value; }
        }
        #endregion

        #region Propriété d'affichage
        public string FicheDescriptive
        {
            get
            {
                return string.Format("{0}, {1}, {2}, {3}, {4}", id, nom, description, id_jeu, id_cat_objet);
            }

        }
        #endregion

        #region Construtor
        public Objet(int id, string nom, string description, int id_jeu, int id_cat_objet)
        {
            Id = id;
            Nom = nom;
            Description = description;
            Id_jeu = id_jeu;
            Id_cat_objet = id_cat_objet;
        }
        #endregion
    }
}
