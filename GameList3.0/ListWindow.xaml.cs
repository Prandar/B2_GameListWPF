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
    }
}
