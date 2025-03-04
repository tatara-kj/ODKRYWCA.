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

using System.IO;

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
            GlownaStrona.Navigate(new glowna());

            
            string sciezka = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "kontynenty","zdjecia", "A New Adventure  D&DTTRPG Adventure Music  1 Hour (1).mp3");


            
                backgroundMusic.Source = new Uri(sciezka, UriKind.Absolute);
                backgroundMusic.Volume = 0.25;  // 25% głośności
                backgroundMusic.LoadedBehavior = MediaState.Manual; // Zapewnia kontrolę nad odtwarzaniem
                backgroundMusic.Play();
         

        }
    }
}
