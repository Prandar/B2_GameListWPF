using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    public class Contenant
    {
        #region Attributs
        private int id;
        private int id_jeu;
        private string nom;
        #endregion

        #region Méthode get/set
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

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        #endregion

        #region Construtor
        public Contenant(int id, int id_jeu, string nom)
        {
            Id = id;
            Id_jeu = id_jeu;
            Nom = nom;
        }
        #endregion
    }
}
