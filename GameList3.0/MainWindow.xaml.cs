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
        List<Objet> listObjets = new List<Objet>();
        List<Lieu> listLieux = new List<Lieu>();
        List<ObjLieu> listObjLieux = new List<ObjLieu>();

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

            Objet Pioche_en_fer = new Objet(0, "Pioche en fer", "Pioche, utile pour miner les roches dures (roche, pavé, minerai, etc.), Elle est utilisable 251 fois", 0, 0);
            Objet Casque_en_fer = new Objet(1, "Casque en fer", "Armure résistante, elle protège la tête, elle peut résister à 166 points de dégats", 0, 0);
            Objet Lingot_de_fer = new Objet(2, "Lingot de fer", "Les lingots de fer permettent la fabrication d'outils, armes et armures solides, permettant de miner certaines roches dure, comme le minerai de diamant)", 0, 0);
            Objet Bois_de_chene = new Objet(3, "Bois de chêne", "Ce bloc compose le tronc des chênes. Il peut être utiliser comme combustible dans les fours", 0, 0);
            Objet Planche_de_chene = new Objet(4, "PLanche de chêne", "Les planches de bois doivent être crafté à partir d'un tronc de chene. Il peut être utilisé comme combustible dans un four)", 0, 0;
            Objet Baton = new Objet(6, "Baton", " Utilisé pour la création de nombreux objets et outils en bois", 0, 0);
            listObjets.Add(Pioche_en_fer);
            listObjets.Add(Casque_en_fer);
            listObjets.Add(Lingot_de_fer);
            listObjets.Add(Bois_de_chene);
            listObjets.Add(Planche_de_chene);
            listObjets.Add(Baton);

            Lieu Aucun = new Lieu(0, 0, "Aucun");
            Lieu Grotte = new Lieu(1, 0, "Grotte");
            Lieu Village = new Lieu(2, 0, "Village");
            Lieu Foret = new Lieu(3, 0, "Forêt");
            listLieux.Add(Aucun);
            listLieux.Add(Grotte);
            listLieux.Add(Village);
            listLieux.Add(Foret);

            ObjLieu Pioche_en_fer_aucun = new ObjLieu(0, 0, 0);
            ObjLieu Casque_en_fer_aucun = new ObjLieu(1, 0, 1);
            ObjLieu Lingot_de_fer_aucun = new ObjLieu(2, 0, 2);
            ObjLieu Bois_de_chene_foret = new ObjLieu(3, 3, 3);
            ObjLieu Planche_de_chene_aucun = new ObjLieu(4, 0, 4);
            ObjLieu Baton_aucun = new ObjLieu(5, 0, 5).






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
            MainWindow_Canva_Incrip.Visibility = Visibility.Visible;
        }

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
                    Console.WriteLine("Erreur de connection !");
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
