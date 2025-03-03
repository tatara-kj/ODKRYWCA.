using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Media;
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
            string clickSoundPath = @"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\old-radio-button-click-97549.mp3";

            // Ustaw ścieżkę do dźwięku kliknięcia
            clickSound.Source = new Uri(clickSoundPath, UriKind.Absolute);

            // Inne ustawienia, jeśli potrzeba
            clickSound.LoadedBehavior = MediaState.Manual; // Zapewni manualne kontrolowanie
            clickSound.UnloadedBehavior = MediaState.Manual;

            // Możesz także ustawić dźwięk do odtwarzania w tle
        }
        private MediaPlayer player = new MediaPlayer();

        private void asia_click(object sender, RoutedEventArgs e)
        {

            player.Stop();
            player.Volume = 0.5 * 0.8;
            player.Open(new Uri("pack://application:,,,\\zdjecia\\old-radio-button-click-97549.mp3"));
            player.Play();
            NavigationService.Navigate(new azja());



        }

        private void afryka_click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Volume = 0.5 * 0.8;
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\old-radio-button-click-97549.mp3"));
            player.Play();
            clickSound.Play();
            NavigationService.Navigate(new kontynenty.afryka());
        }

        private void australia_click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Volume = 0.5 * 0.8;
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\old-radio-button-click-97549.mp3"));
            player.Play();
            clickSound.Play();

            NavigationService.Navigate(new kontynenty.australia());
        }

        private void europa_click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Volume = 0.5 * 0.8;
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\old-radio-button-click-97549.mp3"));
            player.Play();

            NavigationService.Navigate(new kontynenty.europa());
        }

        private void bliskiws_click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Volume = 0.5 * 0.8;
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\old-radio-button-click-97549.mp3"));
            player.Play();
            clickSound.Play();
            NavigationService.Navigate(new kontynenty.australia());
        }

        private void amerykas_click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Volume = 0.5 * 0.8;
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\old-radio-button-click-97549.mp3"));
            player.Play();
            clickSound.Play();
            NavigationService.Navigate(new kontynenty.amerykan());
        }
        private void amerykan_click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Volume = 0.5 * 0.8;
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\old-radio-button-click-97549.mp3"));
            player.Play();
            clickSound.Play();
            NavigationService.Navigate(new kontynenty.amerykan());
        }


        private void wejscie(object sender, MouseEventArgs e)
        {
            Path ksztalt = sender as Path;

            if (ksztalt != null)
            {
                ksztalt.Stroke = Brushes.YellowGreen;

                DropShadowEffect cien = new DropShadowEffect();
                cien.Color = Colors.YellowGreen;
                cien.BlurRadius = 20;
                cien.ShadowDepth = 0;
                cien.Opacity = 0.9;

                ksztalt.Effect = cien;
            }
        }

        private void wyjscie(object sender, MouseEventArgs e)
        {
            Path ksztalt = sender as Path;

            if (ksztalt != null)
            {
                ksztalt.Stroke = null;
                ksztalt.Effect = null;
            }
        }

    }
}
