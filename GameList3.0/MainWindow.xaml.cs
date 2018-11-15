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
        List<Categorie> listCategories = new List<Categorie>();
        List<Jeu> listJeux = new List<Jeu>();
        List<Objet> listObjets = new List<Objet>();
        List<Lieu> listLieux = new List<Lieu>();
        List<ObjLieu> listObjLieux = new List<ObjLieu>();
        bool isConnected = false;

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
            Objet Planche_de_chene = new Objet(4, "PLanche de chêne", "Les planches de bois doivent être crafté à partir d'un tronc de chene. Il peut être utilisé comme combustible dans un four)", 0, 0);
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
        }

        public MainWindow()
        {
            InitializeComponent();
            BullShit_achanger();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (MainWindow_Label_LogIn.Content.ToString() == "Vide")
            {
                Connexion connexion = new Connexion();
                connexion.Show();
            }
            else
            {
                MessageBox.Show("-!- Bonjour -!-");
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TesT_TesT_Click(object sender, RoutedEventArgs e)
        {
            isConnected = true;
            //Console.WriteLine("ce test marche");
            //Console.WriteLine(isConnected.ToString());

            if (isConnected == true)
            {
                foreach (var jeu in listJeux)
                {
                    ListViewItem itemDeBase = new ListViewItem();
                    itemDeBase.Background = Brushes.Green;
                    itemDeBase.Foreground = Brushes.White;
                    itemDeBase.FontSize = 25;
                    itemDeBase.Content = jeu.Nom;
                    MainWindow_ListView_listjeu.Items.Add(itemDeBase);
                }
            }
        }

        private void MainWindow_ListView_listjeu_GotFocus(object sender, RoutedEventArgs e)
        {
            foreach (ListViewItem item in MainWindow_ListView_listjeu.SelectedItems)
            {
                Console.WriteLine(item.Content.ToString());
            }
            Console.WriteLine("is that here");
        }
    }
}
