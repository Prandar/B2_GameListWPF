using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    class Recette
    {
        #region Attributs
        private int id;
        private int id_jeu;
        private string description;
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

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Constructor
        public Recette(int id, int id_jeu, string description)
        {
            Id = id;
            Id_jeu = id_jeu;
            Description = description;
        }
        #endregion

    }
}
