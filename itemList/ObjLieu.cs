using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    class ObjLieu
    {
        #region Attributs
        private int id;
        private int id_lieu;
        private int id_objet;
        #endregion

        #region Méthode get/set
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_lieu
        {
            get { return id_lieu; }
            set { id_lieu = value; }
        }

        public int Id_objet
        {
            get { return id_objet; }
            set { id_objet = value; }
        }
        #endregion

        #region Construtor
        public ObjLieu(int id, int id_lieu, int id_objet)
        {
            Id = id;
            Id_lieu = id_lieu;
            Id_objet = id_objet;
        }
        #endregion
    }
}
