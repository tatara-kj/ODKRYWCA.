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
using System.Media;
using System.Numerics;
namespace odkrywca1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SoundPlayer clickSound;
        public MainWindow()
        {
            InitializeComponent();
            GlownaStrona.Navigate(new glowna());

            InitializeComponent();

            // Ustaw ścieżkę do pliku audio
            backgroundMusic.Source = new Uri("C:\\Users\\jtataruch1\\Source\\Repos\\ODKRYWCA\\zdjecia\\A New Adventure  D&DTTRPG Adventure Music  1 Hour (1).mp3", UriKind.RelativeOrAbsolute);

            // Ustaw parametry odtwarzania
            backgroundMusic.Volume = 0.5;  // Głośność od 0 do 1
       // Powtarzaj dźwięk w pętli

            // Rozpocznij odtwarzanie dźwięku
            backgroundMusic.Play();

        }

        

    }
}