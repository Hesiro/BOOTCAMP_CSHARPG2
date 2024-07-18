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

namespace WpfAppEventos
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy Button 1", "Aviso");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy Button 2", "Aviso");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy Button 3", "Aviso");
        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy Panel", "Aviso");
        }
    }
}