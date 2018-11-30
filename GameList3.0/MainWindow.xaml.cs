using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        List<Contenant> listContenants = new List<Contenant>();
        List<ObjCont> listObjConts = new List<ObjCont>();
        List<Necessite> listNecessites = new List<Necessite>();
        List<Recette> listRecettes = new List<Recette>();

        public DataG donnees = new DataG(false);


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
            Objet Baton = new Objet(5, "Baton", " Utilisé pour la création de nombreux objets et outils en bois", 0, 0);
            Objet Minerai_de_fer = new Objet(6, "Minerai de fer", "Bloc permettant après la cuisson dans un four four d'obtenir des lingots de fer.", 0, 0);
            listObjets.Add(Pioche_en_fer);
            listObjets.Add(Casque_en_fer);
            listObjets.Add(Lingot_de_fer);
            listObjets.Add(Bois_de_chene);
            listObjets.Add(Planche_de_chene);
            listObjets.Add(Baton);
            listObjets.Add(Minerai_de_fer);

            Lieu Aucun_lieu = new Lieu(0, 0, "Aucun");
            Lieu Grotte = new Lieu(1, 0, "Grotte");
            Lieu Foret = new Lieu(2, 0, "Forêt");
            listLieux.Add(Aucun_lieu);
            listLieux.Add(Grotte);
            listLieux.Add(Foret);

            ObjLieu Pioche_en_fer_aucun_lieu = new ObjLieu(0, 0, 0);
            ObjLieu Casque_en_fer_aucun_lieu = new ObjLieu(1, 0, 1);
            ObjLieu Lingot_de_fer_aucun_lieu = new ObjLieu(2, 0, 2);
            ObjLieu Bois_de_chene_Foret = new ObjLieu(3, 2, 3);
            ObjLieu Planche_de_chene_aucun_lieu = new ObjLieu(4, 0, 4);
            ObjLieu Baton_aucun = new ObjLieu(5, 0, 5);
            ObjLieu Minerai_de_fer_grotte = new ObjLieu(5, 1, 6);
            listObjLieux.Add(Pioche_en_fer_aucun_lieu);
            listObjLieux.Add(Casque_en_fer_aucun_lieu);
            listObjLieux.Add(Lingot_de_fer_aucun_lieu);
            listObjLieux.Add(Bois_de_chene_Foret);
            listObjLieux.Add(Planche_de_chene_aucun_lieu);
            listObjLieux.Add(Baton_aucun);
            listObjLieux.Add(Minerai_de_fer_grotte);

            Contenant Aucun_contenant = new Contenant(0, 0, "Aucun");
            Contenant Zombie = new Contenant(1, 0, "Zombie");
            Contenant Coffre = new Contenant(2, 0, "Coffre");
            Contenant Sorciere = new Contenant(3, 0, "Sorcière");
            Contenant Golem_de_fer = new Contenant(4, 0, "Golem de fer");
            Contenant Arbre = new Contenant(5, 0, "Arbre");
            listContenants.Add(Aucun_contenant);
            listContenants.Add(Zombie);
            listContenants.Add(Coffre);
            listContenants.Add(Sorciere);
            listContenants.Add(Golem_de_fer);
            listContenants.Add(Arbre);

            ObjCont Pioche_en_fer_aucun_contenant = new ObjCont(0, 0, 0);
            ObjCont Casque_en_fer_zombie = new ObjCont(1, 1, 1);
            ObjCont Lingot_de_fer_zombie = new ObjCont(2, 1, 2);
            ObjCont Lingot_de_fer_golem_de_fer = new ObjCont(3, 4, 2);
            ObjCont Bois_de_chene_Arbre = new ObjCont(4, 5, 3);
            ObjCont Planche_de_chene_aucun_contenant = new ObjCont(5, 0, 4);
            ObjCont Baton_aucun_contenant = new ObjCont(6, 0, 5);
            ObjCont Minerai_de_fer_aucun_contenant = new ObjCont(7, 0, 6);
            listObjConts.Add(Pioche_en_fer_aucun_contenant);
            listObjConts.Add(Casque_en_fer_zombie);
            listObjConts.Add(Lingot_de_fer_zombie);
            listObjConts.Add(Lingot_de_fer_golem_de_fer);
            listObjConts.Add(Bois_de_chene_Arbre);
            listObjConts.Add(Planche_de_chene_aucun_contenant);
            listObjConts.Add(Baton_aucun_contenant);
            listObjConts.Add(Minerai_de_fer_aucun_contenant);

            Necessite Pioche_en_fer_necessite_lingot = new Necessite(0, 0, 2, 3);
            Necessite Pioche_en_fer_necessite_baton = new Necessite(1, 0, 5, 2);
            Necessite Casque_en_fer_necessite_lingot = new Necessite(2, 1, 2, 5);
            Necessite Lingot_de_fer_necessite_minerai_de_fer = new Necessite(3, 2, 6, 1);
            Necessite Planche_de_chene_necessite_bois_de_chene = new Necessite(4, 4, 3, 0.25);
            Necessite Baton_necessite_bois_de_chene = new Necessite(5, 5, 4, 0.5);
            Necessite truc = new Necessite(99, 66, 33, 11);
            listNecessites.Add(truc);
            listNecessites.Add(Pioche_en_fer_necessite_lingot);
            listNecessites.Add(Pioche_en_fer_necessite_baton);
            listNecessites.Add(Casque_en_fer_necessite_lingot);
            listNecessites.Add(Lingot_de_fer_necessite_minerai_de_fer);
            listNecessites.Add(Planche_de_chene_necessite_bois_de_chene);
            listNecessites.Add(Baton_necessite_bois_de_chene);

            Recette Pioche_en_fer_recette = new Recette(0, 0,  0, "Pioche, utile pour miner les roches dures (roche, pavé, minerai, etc.), Elle est utilisable 251 fois");
            Recette Casque_en_fer_recette = new Recette(1, 1, 0, "Armure résistante, elle protège la tête, elle peut résister à 166 points de dégats");
            Recette Lingot_de_fer_recette = new Recette(2, 2, 0, "Les lingots de fer permettent la fabrication d'outils, armes et armures solides, permettant de miner certaines roches dure, comme le minerai de diamant");
            Recette Planche_de_chene_recette = new Recette(3, 4, 0, "Les planches de bois doivent être crafté à partir d'un tronc de chene. Il peut être utilisé comme combustible dans un four)");
            listRecettes.Add(Pioche_en_fer_recette);
            listRecettes.Add(Casque_en_fer_recette);
            listRecettes.Add(Lingot_de_fer_recette);
            listRecettes.Add(Planche_de_chene_recette);

        }

        public MainWindow()
        {
            InitializeComponent();
            BullShit_achanger();
            AfficherObjet(listObjets);
            AfficherObjetNecessite(listNecessites);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (MainWindow_Label_LogIn.Content.ToString() == "Vide")
            {
                Connexion connexion = new Connexion();
                connexion.Closing += new CancelEventHandler(connexion_Closing);
                connexion.Show();
                //connexion.ShowDialog();
            }
            else
            {
                MessageBox.Show("-!- Bonjour -!-");
            }
        }
        void connexion_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var connexion = sender as Connexion;
            //Information.Text = connexion.EnteredText.Text;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void TesT_TesT_Click(object sender, RoutedEventArgs e)
        {
            donnees.IsConnected = true;
            //Console.WriteLine("ce test marche");
            //Console.WriteLine(isConnected.ToString());

            if (donnees.IsConnected == true)
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

        static void AfficherObjet(List<Objet> objets)
        {
            foreach (Objet p in objets)
            {
                Console.WriteLine(p.FicheDescriptive);
            }
        }

        static void AfficherObjetNecessite(List<Necessite> objetnecessite)
        {
            foreach (Necessite p in objetnecessite)
            {
                Console.WriteLine(p.FicheDescriptive);
            }
        }

        private void MainWindow_ListView_listjeu_GotFocus(object sender, RoutedEventArgs e)
        {
            //.WriteLine(MainWindow_ListView_listjeu.SelectedListViewItemCollection);

            //int i = 0;
            //foreach (ListViewItem item in MainWindow_ListView_listjeu.Items)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            foreach (var objet in listObjets)
            {
                ListViewItem itemDeBase = new ListViewItem();
                itemDeBase.Background = Brushes.Red;
                itemDeBase.Foreground = Brushes.White;
                itemDeBase.FontSize = 25;
                itemDeBase.Content = objet.Nom;
                MainWindow_ListView_listjeu.Items.Add(itemDeBase);
            }
        }

        private void MainWindow_ListItem_test_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
