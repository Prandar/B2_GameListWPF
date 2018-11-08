using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    public class Utilisateur
    {
        #region Attributs
        private int id;
        private string login;
        private string mdp;
        private string mail;
        #endregion

        #region Methode get/set
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Mdp
        {
            get { return mdp; }
            set { mdp = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        #endregion

        #region AutreMethode
        public string Identite
        {
            get { return string.Format("{0}, {1}, {2}, {3}", id, login, mdp, mail); }
        }
        #endregion

        #region Constructor
        public Utilisateur(int id, string login, string mdp, string mail)
        {
            Id = id;
            Login = login;
            Mdp = mdp;
            Mail = mail;
        }
        #endregion
    }
}
