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
        private double quantite;
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

        public double Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        #endregion

        #region Propriété d'affichage
        public string FicheDescriptive
        {
            get
            { return string.Format("{0}, {1}, {2}, {3}", id, id_objet, id_objet_nec, Quantite); }

        }
        #endregion

        #region Construtor
        public Necessite(int id, int id_objet, int id_objet_nec, double quantite)
        {
            Id = id;
            Id_objet = id_objet;
            Id_objet_nec = id_objet_nec;
            Quantite = quantite;
        }
        #endregion
    }
}
