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

namespace pr4
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

        private void Proiti_Test_Click(object sender, RoutedEventArgs e)
        {
        bububuWindow testContent = new bububuWindow(false);
            testContent.Pages.Content = new Page1();
            testContent.Show();
            
            Close();
        }

        private void Edit_Test_Click(object sender, RoutedEventArgs e)
        {
            PasswordBox1.Visibility = Visibility.Visible;
        }

        private void PasswordBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string password = "qwertym";
            if (PasswordBox1.Text == password && e.Key==Key.Enter )
            {
                bububuWindow testContent = new bububuWindow(true);
                testContent.Show();
                Close();
            }
            else if (PasswordBox1.Text != password && e.Key == Key.Enter)
            {
                var message = MessageBox.Show("Неправильный пароль!");
            }
        }
    }
}