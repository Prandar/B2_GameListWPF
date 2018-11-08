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

        public MainWindow()
        {
            InitializeComponent();
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
    }
}
