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
        List<Categorie> listCategories = new List<Categorie>();
        List<Jeu> listJeux = new List<Jeu>();

        public void RemplirListUser()
        {
            Utilisateur UserYohan = new Utilisateur(0, "Yohan", "Admin", "yohan.angelini@epsi.fr");
            Utilisateur UserRomain = new Utilisateur(1, "Romain", "password", "romain.prangere@epsi.fr");
            listUsers.Add(UserYohan);
            listUsers.Add(UserRomain);
            //Console.WriteLine(listUsers.Count);

        }

        public void BullShit_achanger()
        {
            Categorie SandBox = new Categorie(0, "Sand Box");
            Categorie Rpg = new Categorie(0, "RPG");
            listCategories.Add(SandBox);
            listCategories.Add(Rpg);

            Jeu Minecraft = new Jeu(0, "Minecraft", 0, 2009, "Mojang");
            Jeu TheWitcher3 = new Jeu(1, "The Wither 3 : Wild Hunt", 1, 2015, "CD Red Project");
            listJeux.Add(Minecraft);
            listJeux.Add(TheWitcher3);
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

        private void Co_Button_Inscription_Click(object sender, RoutedEventArgs e)
        {
            MainWindow_Canvas_Co.Visibility = Visibility.Hidden;
            MainWindow_Canva_Incrip.Visibility = Visibility.Visible;        }

        private void Co_Button_Connexion_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(Co_TextBox_InputLogin.Text);
            //Console.WriteLine(Co_TextBox_InputMdp.Text);
            //Console.WriteLine(listUsers.Count);
            if ( ! ( (string.IsNullOrEmpty(Co_TextBox_InputLogin.Text)) && (string.IsNullOrEmpty(Co_TextBox_InputMdp.Text)) ) )
            {
                if(Verif(listUsers, Co_TextBox_InputLogin.Text, Co_TextBox_InputMdp.Text) != -1)
                {
                    Console.WriteLine("Vous êtes connecté");
                    Console.WriteLine(Verif(listUsers, Co_TextBox_InputLogin.Text, Co_TextBox_InputMdp.Text));
                }
                else
                {
                    Console.WriteLine("Erreur de connection");
                }
                
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs avec vos identifiants");
            }
                
        }

        private void Co_TextBox_InputLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Co_TextBox_InputMdp_TextChanged(object sender, TextChangedEventArgs e)
        {

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
                MainWindow_Canva_Incrip.Visibility = Visibility.Hidden;
                MainWindow_Canvas_Co.Visibility = Visibility.Visible;
    }
            else
            {
                Console.WriteLine("Veuillez entrez vos identifiants");
            }

        }
    }
}
