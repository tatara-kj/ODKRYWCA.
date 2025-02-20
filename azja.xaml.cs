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
            powrot_grid.Visibility = Visibility.Collapsed;
            kontynent.Visibility = Visibility.Collapsed;

            quiz.Visibility = Visibility.Visible;
        }

        private void sprawdz(object sender, RoutedEventArgs e)
        {
            int licznik = 0;
            string[] poprawneOdpowiedzi = { "1", "2", "1", "1", "1" };
            StackPanel[] pytania = { pyt1, pyt2, pyt3, pyt4, pyt5 };
            int liczba_pytan = pytania.Length;

            for (int i = 0; i < liczba_pytan; i++) // przehcodzi po pytaniach
            {
                for (int j = 0; j < 4; j++) //przechdozi po odpoiwedziach
                {
                    if (pytania[i].Children[j] is RadioButton rb)//sprawdza czy to radiobut i przypisuje do rb zmiennej
                    {
                        if (rb.IsChecked == true) 
                        {
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
            }
            wynik.Content = "Wynik: " + (double)licznik / liczba_pytan * 100 + "%";
        }


    }
}
