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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace odkrywca1
{
    /// <summary>
    /// Logika interakcji dla klasy glowna.xaml
    /// </summary>
    public partial class glowna : Page
    {
        public glowna()
        {
            InitializeComponent();
        }
        private void asia_click(object sender, RoutedEventArgs e)
        {


            NavigationService.Navigate(new azja());



        }

        private void afryka_click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("afryka");
        }

        private void australia_click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("australia");
        }

        private void europa_click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("europa");
        }

        private void bliskiws_click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("bliski wschod");
        }

        private void amerykas_click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("ameryka poln ocna");
        }
        private void amerykan_click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("amryka poludniowa");
        }


        private void wejscie(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            Path path = button.Template.FindName("myPath", button) as Path;

            if (path != null)
            {
                if (e.RoutedEvent.Name == "MouseEnter")
                {
                    path.Stroke = Brushes.YellowGreen;
                    path.Effect = new DropShadowEffect
                    {
                        Color = Colors.YellowGreen,
                        BlurRadius = 20,
                        ShadowDepth = 0,
                        Opacity = 0.9
                    };
                }
                else if (e.RoutedEvent.Name == "MouseLeave")
                {
                    path.Stroke = null;
                    path.Effect = null;
                }
            }
        }
    }
}
