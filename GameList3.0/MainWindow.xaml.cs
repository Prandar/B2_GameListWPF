using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using itemList;

namespace GameListWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Utilisateur> listUsers = new List<Utilisateur>();

        public void RemplirListUser()
        {
            Utilisateur UserYohan = new Utilisateur(0, "Yohan", "Admin", "yohan.angelini@epsi.fr");
            Utilisateur UserRomain = new Utilisateur(0, "Romain", "password", "romain.prangere@epsi.fr");
            listUsers.Add(UserYohan);
            listUsers.Add(UserRomain);
        }
        public int Verif(List<Utilisateur> _listUser, string _login, string _mdp)
        {
            foreach (Utilisateur _user in _listUser)
            {
                if (_user.Login == _login && _user.Mdp == _mdp)
                {
                    return _user.Id;
                }
            }
            return -1;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        public void 
    }
}
