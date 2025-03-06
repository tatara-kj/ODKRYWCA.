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
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using PathIO = System.IO.Path;  // Alias dla System.IO.Path
using System.IO;
using System.Security.Cryptography;

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
        private MediaPlayer player = new MediaPlayer();
        private void OdtworzDzwiek()
        {

            string sciezka = PathIO.Combine(AppDomain.CurrentDomain.BaseDirectory, "kontynenty", "zdjecia", "old-radio-button-click-97549.mp3");


            if (File.Exists(sciezka))
            {
                player.Stop();
                player.Volume = 0.5 * 1.2;
                player.Open(new Uri(sciezka, UriKind.Absolute));
                player.Play();
            }
            else
            {
                MessageBox.Show("Plik dźwiękowy nie istnieje!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void asia_click(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();

            DoubleAnimation animacjaZanikania = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));
            animacjaZanikania.Completed += (s, eArgs) =>
            {
                NavigationService.Navigate(new azja());

                DoubleAnimation animacjaPowrotu = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
                ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaPowrotu);
            };

            ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaZanikania);
        }

        DoubleAnimation animacjaZanikania = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));
        private void afryka_click(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();

            DoubleAnimation animacjaZanikania = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));
            animacjaZanikania.Completed += (s, eArgs) =>
            {
                NavigationService.Navigate(new kontynenty.afryka());

                DoubleAnimation animacjaPowrotu = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
                ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaPowrotu);
            };

            ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaZanikania);
        }

        private void australia_click(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();

            DoubleAnimation animacjaZanikania = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));
            animacjaZanikania.Completed += (s, eArgs) =>
            {
                NavigationService.Navigate(new kontynenty.australia());

                DoubleAnimation animacjaPowrotu = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
                ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaPowrotu);
            };

            ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaZanikania);
        }

        private void europa_click(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();

            DoubleAnimation animacjaZanikania = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));

            animacjaZanikania.Completed += (s, eArgs) =>
            {
                NavigationService.Navigate(new kontynenty.europa());

                ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5)));
            };

            ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaZanikania);
        }

        private void bliskiws_click(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();
            DoubleAnimation animacjaZanikania = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));
            animacjaZanikania.Completed += (s, eArgs) =>
            {
                NavigationService.Navigate(new kontynenty.australia());

                DoubleAnimation animacjaPowrotu = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
                ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaPowrotu);
            };

            ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaZanikania);
        }

        private void amerykas_click(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();
            DoubleAnimation animacjaZanikania = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));
            animacjaZanikania.Completed += (s, eArgs) =>
            {
                NavigationService.Navigate(new kontynenty.amerykas());

                DoubleAnimation animacjaPowrotu = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
                ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaPowrotu);
            };

            ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaZanikania);
        }

        private void amerykan_click(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();

            DoubleAnimation animacjaZanikania = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));
            animacjaZanikania.Completed += (s, eArgs) =>
            {
                NavigationService.Navigate(new kontynenty.amerykas());

                DoubleAnimation animacjaPowrotu = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
                ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaPowrotu);
            };

            ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaZanikania);
        }

        private void wejscie(object sender, MouseEventArgs e)
        {
          
            System.Windows.Shapes.Path ksztalt = sender as System.Windows.Shapes.Path; 

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
            
            System.Windows.Shapes.Path ksztalt = sender as System.Windows.Shapes.Path; 

            if (ksztalt != null)
            {
                ksztalt.Stroke = null;
                ksztalt.Effect = null;
            }
        }
    }
}
