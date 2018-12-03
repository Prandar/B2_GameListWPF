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
    /// Logique d'interaction pour ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        public List<Objet>     listObjetsFin     = new List<Objet>();
        public List<Necessite> listNecessitesFin = new List<Necessite>();
        public int NbObjFIN = 0;
        public int NbNecFIN = 0;

        public ListWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("listObjetsFin : " + listObjetsFin.Count);

            foreach (var item in listObjetsFin)
            {
                Console.WriteLine(item.Description);
            }

            Console.WriteLine("listNecessitesFin : " + listNecessitesFin.Count);

            foreach (var item in listNecessitesFin)
            {
                Console.WriteLine(item.FicheDescriptive);
            }
        }

        #region FonctionP
        public void AfficheListFin()
        {
            ListWindow_ListView_listCraft.Items.Clear();
            ListWindow_ListView_listCraftN.Items.Clear();
            foreach (var item in listObjetsFin)
            {
                ListViewItem itemDeBase = new ListViewItem();
                itemDeBase.Background = Brushes.DarkRed;
                itemDeBase.Foreground = Brushes.White;
                itemDeBase.FontSize = 25;
                itemDeBase.Content = item.Nom;
                itemDeBase.AddHandler(Control.MouseDoubleClickEvent, new RoutedEventHandler(ListWindow_ListView_listCraft_DoubleClick));
                ListWindow_ListView_listCraft.Items.Add(itemDeBase);
            }

            foreach (var item in listNecessitesFin)
            {
                ListViewItem itemDeBase = new ListViewItem();
                if (item.Quantite <= 0)
                {
                    itemDeBase.Background = Brushes.PaleGoldenrod;
                    itemDeBase.Foreground = Brushes.White;
                }
                else
                {
                    itemDeBase.Background = Brushes.DarkOrange;
                    itemDeBase.Foreground = Brushes.White;
                }
                itemDeBase.FontSize = 25;
                itemDeBase.Content = MainWindow.GetNomObjetParId(item.Id_objet_nec) + " x" + item.Quantite;
                itemDeBase.AddHandler(Control.MouseDoubleClickEvent, new RoutedEventHandler(ListWindow_ListView_listCraftN_DoubleClick));
                ListWindow_ListView_listCraftN.Items.Add(itemDeBase);
            }
        }

        protected void ListWindow_ListView_listCraft_DoubleClick(object sender, RoutedEventArgs e)
        {
            DependencyObject depObj = e.OriginalSource as DependencyObject;
            if (depObj != null)
            {
                // go up the visual hierarchy until we find the list view item the click came from  
                // the click might have been on the grid or column headers so we need to cater for this  
                DependencyObject current = depObj;
                while (current != null && current != ListWindow_ListView_listCraft)
                {
                    ListViewItem lvi = current as ListViewItem;
                    if (lvi != null)
                    {
                        // this is the list view item  
                        // do something with it here  
                        Console.WriteLine(lvi.Content.ToString());
                        // break out of loop  
                        return;
                    }
                    current = VisualTreeHelper.GetParent(current);
                }
            }
        }

        protected void ListWindow_ListView_listCraftN_DoubleClick(object sender, RoutedEventArgs e)
        {
            DependencyObject depObj = e.OriginalSource as DependencyObject;
            if (depObj != null)
            {
                // go up the visual hierarchy until we find the list view item the click came from  
                // the click might have been on the grid or column headers so we need to cater for this  
                DependencyObject current = depObj;
                while (current != null && current != ListWindow_ListView_listCraftN)
                {
                    ListViewItem lvi = current as ListViewItem;
                    if (lvi != null)
                    {
                        // this is the list view item  
                        // do something with it here  
                        string nom = lvi.Content.ToString();
                        int id = MainWindow.GetIdNecessiteParNomObjet(nom);
                        Console.WriteLine(lvi.Content.ToString());
                        // break out of loop  
                        return;
                    }
                    current = VisualTreeHelper.GetParent(current);
                }
            }
        }

        #endregion
    }
}
