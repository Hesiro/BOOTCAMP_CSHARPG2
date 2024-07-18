using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppRadioButton
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

        private void rbRojo_Click(object sender, RoutedEventArgs e)
        {
            elipseRoja.Visibility = Visibility.Visible;
            elipseAmarilla.Visibility = Visibility.Hidden;
            elipseVerde.Visibility = Visibility.Hidden;
        }

        private void rbAmarillo_Click(object sender, RoutedEventArgs e)
        {
            elipseRoja.Visibility = Visibility.Hidden;
            elipseAmarilla.Visibility = Visibility.Visible;
            elipseVerde.Visibility = Visibility.Hidden;
        }

        private void rbVerde_Click(object sender, RoutedEventArgs e)
        {
            elipseRoja.Visibility = Visibility.Hidden;
            elipseAmarilla.Visibility = Visibility.Hidden;
            elipseVerde.Visibility = Visibility.Visible;
        }
    }
}