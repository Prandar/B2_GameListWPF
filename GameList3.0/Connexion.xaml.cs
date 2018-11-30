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
using System.Windows.Shapes;
using itemList;

namespace GameListWPF
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {
        List<Utilisateur> listUsers = new List<Utilisateur>();
        public void RemplirListUser()
        {
            Utilisateur UserYohan = new Utilisateur(0, "yohan", "admin", "yohan.angelini@epsi.fr");
            Utilisateur UserRomain = new Utilisateur(1, "romain", "password", "romain.prangere@epsi.fr");
            listUsers.Add(UserYohan);
            listUsers.Add(UserRomain);
            //Console.WriteLine(listUsers.Count);

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

        public Connexion()
        {
            InitializeComponent();
        }

        private void Co_Button_Inscription_Click(object sender, RoutedEventArgs e)
        {
            MainWindow_Canvas_Co.Visibility = Visibility.Hidden;
            MainWindow_Canva_Incrip.Visibility = Visibility.Visible;
        }

        private void Co_Button_Connexion_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(Co_TextBox_InputLogin.Text);
            //Console.WriteLine(Co_TextBox_InputMdp.Text);
            //Console.WriteLine(listUsers.Count);
            if (!((string.IsNullOrEmpty(Co_TextBox_InputLogin.Text)) && (string.IsNullOrEmpty(Co_TextBox_InputMdp.Text))))
            {
                if (Verif(listUsers, Co_TextBox_InputLogin.Text, Co_TextBox_InputMdp.Text) != -1)
                {
                    MessageBox.Show("Vous êtes connecté");
                    //MainWindow.MainWindow_ListView_listjeu.SetValue();
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur de connection !");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs avec vos identifiants");
            }
        }

        private void MainWindow_Canvas_Co_Loaded(object sender, RoutedEventArgs e)
        {
            RemplirListUser();
        }

        private void Inscrip_Button_Inscription_Click(object sender, RoutedEventArgs e)
        {
            if (!((string.IsNullOrEmpty(Inscrip_TextBox_InputLogin.Text)) && (string.IsNullOrEmpty(Inscrip_TextBox_InputMdp.Text)) && ((string.IsNullOrEmpty(Inscrip_TextBox_InputMail.Text)))))
            {
                listUsers.Add(new Utilisateur(listUsers.Count, Inscrip_TextBox_InputLogin.Text, Inscrip_TextBox_InputMdp.Text, Inscrip_TextBox_InputMail.Text));
                MessageBox.Show("Inscription Réussi.");
                //TODO enregister ce nouvelle utilisatuer grace a stream write et stream read
                MainWindow_Canva_Incrip.Visibility = Visibility.Hidden;
                MainWindow_Canvas_Co.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs.");
            }

        }

        private void Co_TextBox_InputLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Co_TextBox_InputMdp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Inscrip_Button_Retour_Click(object sender, RoutedEventArgs e)
        {
            MainWindow_Canva_Incrip.Visibility = Visibility.Hidden;
            MainWindow_Canvas_Co.Visibility = Visibility.Visible;
            Inscrip_TextBox_InputLogin.Text = "";
            Inscrip_TextBox_InputMdp.Text = "";
            Inscrip_TextBox_InputMail.Text = "";
        }
    }
}
