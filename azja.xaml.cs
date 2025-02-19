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

namespace odkrywca1
{
    /// <summary>
    /// Logika interakcji dla klasy azja.xaml
    /// </summary>
    public partial class azja : Page
    {
        public azja()
        {
            InitializeComponent();
        }

        private void powrot(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }

        private void powrot_kontynent(object sender, RoutedEventArgs e)
        {
            kontynent.Visibility = Visibility.Visible;
            powrot_grid.Visibility = Visibility.Visible;

            quiz.Visibility = Visibility.Collapsed;
        }

        private void quiz_click(object sender, RoutedEventArgs e)
        {
            powrot_grid.Visibility=Visibility.Collapsed;
            kontynent.Visibility=Visibility.Collapsed;

            quiz.Visibility=Visibility.Visible;
        }

       
    }
}
