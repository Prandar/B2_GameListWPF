using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    public class Categorie
    {
        #region Attributs
        private int id;
        private int id_jeu;
        private string libelle;
        #endregion

        #region Methode get/set
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_jeu
        {
            get { return id_jeu; }
            set { id_jeu = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        #endregion

        #region Constructor
        public Categorie(int id, string description)
        {
            Id = id;
            Id_jeu = 0;
            Libelle = libelle;
        }

        public Categorie(int id, int id_jeu, string description)
        {
            Id = id;
            Id_jeu = id_jeu;
            Libelle = libelle;
        }
        #endregion
    }
}
