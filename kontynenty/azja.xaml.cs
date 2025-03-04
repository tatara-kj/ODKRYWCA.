using System;
using System.Collections.Generic;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Numerics;
using System.Windows.Media.Animation;

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

//testgowno
            // Możesz także ustawić dźwięk do odtwarzania w tle

        }
        private MediaPlayer player = new MediaPlayer();
        private void powrot(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Volume = 0.5 * 1.2;
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\mixkit-modern-click-box-check-1120.wav"));
            player.Play();
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
            player.Stop();
            player.Volume = 0.5 * 1.2;
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\mixkit-modern-click-box-check-1120.wav"));
            player.Play();
            kontynent.Visibility = Visibility.Visible;
            powrot_grid.Visibility = Visibility.Visible;

            quiz.Visibility = Visibility.Collapsed;
        }

        private void quiz_click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Volume = 0.5 * 1.2;
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\mixkit-modern-click-box-check-1120.wav"));
            player.Play();
            powrot_grid.Visibility = Visibility.Collapsed;
            kontynent.Visibility = Visibility.Collapsed;

            quiz.Visibility = Visibility.Visible;
        }

        private StackPanel[] pytania; // Deklaracja tablicy StackPanel

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Inicjalizacja tablicy pytania
            pytania = new StackPanel[] { pyt1, pyt2, pyt3, pyt4, pyt5 };
        }
        private void sprawdz(object sender, RoutedEventArgs e)
        {

            Button button = sender as Button;
            if (button != null)
            {
                button.IsEnabled = false;
            }

            player.Stop();
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\mixkit-modern-click-box-check-1120.wav"));
            player.Play();
            player.Volume = 0.5 * 1.2;
            int licznik = 0;
            string[] poprawneOdpowiedzi = { "1", "2", "1", "1", "1" };
            StackPanel[] pytania = { pyt1, pyt2, pyt3, pyt4, pyt5 };
            int liczba_pytan = pytania.Length;

            for (int i = 0; i < liczba_pytan; i++) // przehcodzi po pytaniach
            {
                bool odpowiedzZaznaczona = false;
                for (int j = 0; j < 4; j++) //przechdozi po odpoiwedziach
                {
                    if (pytania[i].Children[j] is RadioButton rb)//sprawdza czy to radiobut i przypisuje do rb zmiennej
                    {
                        if (rb.IsChecked == true)
                        {
                            odpowiedzZaznaczona = true;
                            if (rb.Tag != null && rb.Tag.ToString() == poprawneOdpowiedzi[i]) // sprawdza czy zanaaczone to poprawna odpowiedz
                            {
                                licznik++;
                                TextBlock dobrzeText = new TextBlock();
                                dobrzeText.Text = "DOBRZE!";
                                dobrzeText.Foreground = Brushes.Green;
                                dobrzeText.FontSize = 30;
                                dobrzeText.Margin = new Thickness(10, 0, 0, 0);
                                pytania[i].Children.Add(dobrzeText);
                            }
                            else
                            {
                                rb.Foreground = Brushes.Red;
                                for (int k = 0; k < pytania[i].Children.Count; k++)
                                {
                                    if (pytania[i].Children[k] is RadioButton correctRb && correctRb.Tag != null && correctRb.Tag.ToString() == poprawneOdpowiedzi[i])
                                    {
                                        correctRb.Foreground = Brushes.Green;
                                    }//szuka poprawenje i zmienia jej kolor na zkeoljnu
                                }
                            }
                        }
                    }
                }
                if (!odpowiedzZaznaczona)
                {
                    TextBlock zle = new TextBlock();
                    zle.Text = "nic nie zaznaczyles!";
                    zle.Foreground = Brushes.Red;
                    zle.FontSize = 30;
                    zle.Margin = new Thickness(10, 0, 0, 0);
                    pytania[i].Children.Add(zle);
                }



            }
            wynik.Content = "Wynik: " + (double)licznik / liczba_pytan * 100 + "%";
            sprawdzz.Visibility = Visibility.Collapsed;
            resett.Visibility = Visibility.Visible;
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Open(new Uri(@"C:\Users\jtataruch1\Source\Repos\ODKRYWCA\zdjecia\mixkit-modern-click-box-check-1120.wav"));
            player.Play();
            player.Volume = 0.5 * 1.2;
            if (pytania == null)
            {
                pytania = new StackPanel[] { pyt1, pyt2, pyt3, pyt4, pyt5 };
            }

            // Resetowanie kolorów RadioButtonów
            for (int i = 0; i < pytania.Length; i++)
            {
                for (int j = 0; j < pytania[i].Children.Count; j++)
                {
                    if (pytania[i].Children[j] is RadioButton rb)
                    {
                        rb.Foreground = Brushes.Black;
                    }
                }
            }

            // Usuwanie tekstów "DOBRZE!" oraz "nic nie zaznaczyłeś!"
            for (int i = 0; i < pytania.Length; i++)
            {
                for (int j = pytania[i].Children.Count - 1; j >= 0; j--)
                {
                    if (pytania[i].Children[j] is TextBlock textBlock)
                    {
                        if (textBlock.Text == "DOBRZE!" || textBlock.Text == "nic nie zaznaczyles!")
                        {
                            pytania[i].Children.RemoveAt(j);  // Usuwamy odpowiedni tekst
                        }
                    }
                }
            }

            // Resetowanie przycisku sprawdzania i widoczności
            sprawdzz.IsEnabled = true;
            wynik.Content = "";
            sprawdzz.Visibility = Visibility.Visible;
            resett.Visibility = Visibility.Collapsed;
        }

    }
    }
