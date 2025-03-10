﻿using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
namespace odkrywca1.kontynenty
{
    /// <summary>
    /// Logika interakcji dla klasy australia.xaml
    /// </summary>
    public partial class australia : Page
    {
        public australia()
        {
            InitializeComponent();
        }
        private MediaPlayer player = new MediaPlayer();
        private void powrot(object sender, RoutedEventArgs e)
        {

            OdtworzDzwiek();
            DoubleAnimation animacjaZanikania = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.5));
            animacjaZanikania.Completed += (s, eArgs) =>
            {
                NavigationService.Navigate(new glowna());


                DoubleAnimation animacjaPowrotu = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
                ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaPowrotu);
            };


            ((MainWindow)Application.Current.MainWindow).BeginAnimation(OpacityProperty, animacjaZanikania);
        }

        private void powrot_kontynent(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();
            kontynent.Visibility = Visibility.Visible;
            powrot_grid.Visibility = Visibility.Visible;

            quiz.Visibility = Visibility.Collapsed;
        }

        private void quiz_click(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();
            powrot_grid.Visibility = Visibility.Collapsed;
            kontynent.Visibility = Visibility.Collapsed;

            quiz.Visibility = Visibility.Visible;
        }

        private StackPanel[] pytania;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            pytania = new StackPanel[] { pyt1, pyt2, pyt3, pyt4, pyt5 };
        }

        int pnkt = 0;
        private void sprawdz(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();
            if (dobra1.IsChecked == true)
            {
                pnkt++;
                label1.Content = "Dobrze";
                label1.Foreground = Brushes.Green;
            }
            else
            {
                label1.Content = "zle, dobra odpowiedz Mont blanc";
                label1.Foreground = Brushes.Red;
            }

            if (dobra2.IsChecked == true)
            {
                pnkt++;
                label2.Content = "Dobrze";
                label2.Foreground = Brushes.Green;
            }
            else
            {
                label2.Content = "zle, dobra odpowiedz Jezioro Ładoga";
                label2.Foreground = Brushes.Red;
            }



            if (dobra3.IsChecked == true)
            {
                pnkt++;
                label3.Content = "Dobrze";
                label3.Foreground = Brushes.Green;
            }
            else
            {
                label3.Content = "zle, dobra odpowiedz Dunaj";
                label3.Foreground = Brushes.Red;
            }



            if (dobra4.IsChecked == true)
            {
                pnkt++;
                label4.Content = "Dobrze";
                label4.Foreground = Brushes.Green;
            }
            else
            {
                label4.Content = "zle, dobra odpowiedz Rosja";
                label4.Foreground = Brushes.Red;
            }



            if (dobra5.IsChecked == true)
            {
                pnkt++;
                label5.Content = "Dobrze";
                label5.Foreground = Brushes.Green;
            }
            else
            {
                label5.Content = "zle, dobra odpowiedz Berlin";
                label5.Foreground = Brushes.Red;
            }

            wynik.Content = "wynik: " + (double)pnkt / 5 * 100 + "%";

            sprawdzz.Visibility = Visibility.Collapsed;
            resett.Visibility = Visibility.Visible;
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();

            pnkt = 0;

            wynik.Content = "";

            label1.Content = "";
            label2.Content = "";
            label3.Content = "";
            label4.Content = "";
            label5.Content = "";





            resett.Visibility = Visibility.Collapsed;
            sprawdzz.Visibility = Visibility.Visible;

        }

        private void OdtworzDzwiek()
        {
            string sciezka = AppDomain.CurrentDomain.BaseDirectory + "kontynenty/zdjecia/mixkit-modern-click-box-check-1120.wav";

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

        int miejsce = 0;

        private void next(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();
            miejsce++;

            if (miejsce == 0)
            {
                img_box.Source = new BitmapImage(new Uri("pack://application:,,,/kontynenty/europe1.jpg"));
            }
            else if (miejsce == 1)
            {
                img_box.Source = new BitmapImage(new Uri("pack://application:,,,/kontynenty/europe2.jpg"));
            }
            else if (miejsce == 2)
            {
                img_box.Source = new BitmapImage(new Uri("pack://application:,,,/kontynenty/europe3.jpg"));
            }

            if (miejsce > 2)
                miejsce = 0;
        }

        private void prev(object sender, RoutedEventArgs e)
        {
            OdtworzDzwiek();
            miejsce--;

            if (miejsce == 0)
            {
                img_box.Source = new BitmapImage(new Uri("pack://application:,,,/kontynenty/europe3.jpg"));
            }
            else if (miejsce == 1)
            {
                img_box.Source = new BitmapImage(new Uri("pack://application:,,,/kontynenty/europe2.jpg"));
            }
            else if (miejsce == 2)
            {
                img_box.Source = new BitmapImage(new Uri("pack://application:,,,/kontynenty/europe1.jpg"));
            }

            if (miejsce < 0)
                miejsce = 2;
        }



    }
}