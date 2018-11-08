using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    public class ObjCont
    {
        #region Attributs
        private int id;
        private int id_contenant;
        private int id_objet;
        #endregion

        #region Méthode get/set
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_contenant
        {
            get { return id_contenant; }
            set { id_contenant = value; }
        }

        public int Id_objet
        {
            get { return id_objet; }
            set { id_objet = value; }
        }
        #endregion

        #region Construtor
        public ObjCont(int id, int id_contenant, int id_objet)
        {
            Id = id;
            Id_contenant = id_contenant;
            Id_objet = id_objet;
        }
        #endregion
    }
}
