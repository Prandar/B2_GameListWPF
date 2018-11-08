using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    public class Necessite
    {
        #region Attributs
        private int id;
        private int id_objet;
        private int id_objet_nec;
        private int quantite;
        #endregion

        #region Méthode get/set
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Id_objet
        {
            get { return id_objet; }
            set { id_objet = value; }
        }

        public int Id_objet_nec
        {
            get { return id_objet_nec; }
            set { id_objet_nec = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        #endregion

        #region Construtor
        public Necessite(int id, int id_objet, int int_objet_nec, int quantite)
        {
            Id = id;
            Id_objet = id_objet;
            Id_objet_nec = id_objet_nec;
            Quantite = quantite;
        }
        #endregion
    }
}
