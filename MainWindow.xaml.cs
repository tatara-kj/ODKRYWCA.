using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void asia_click(object sender, RoutedEventArgs e)
        {


            GlownaStrona.Navigate(new azja());
            mapa.Visibility = Visibility.Hidden;


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
                    path.Effect = new DropShadowEffect {
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