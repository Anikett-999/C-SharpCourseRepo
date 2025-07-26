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

namespace MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Mybutton.Click += Button_Click2();
        }

        private RoutedEventHandler Button_Click2() => (RoutedEventHandler)(Label2.Content = "Hello World !");

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyLabel.Content = "Hello World";
        }
       
    }
}