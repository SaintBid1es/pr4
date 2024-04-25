using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

namespace pr4
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        List<PropertyTest> propertyTests = new List<PropertyTest>();
        string text = string.Empty;
        public Page1()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = propertyTests;

        }


        private void Redactor_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page1();
            MyDataGrid.Visibility = Visibility.Visible;
            propertyTests = JsonConvert.DeserializeObject(text) as List<PropertyTest> ?? new List<PropertyTest>();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ShowActivatedProperty = new MainWindow();
            ShowActivatedProperty.Show();
            
        }

        
        private void Take_the_test_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page2();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            propertyTests.Add(new PropertyTest(null, null, null, null, null));
            MyDataGrid.ItemsSource = null;
            MyDataGrid.ItemsSource = propertyTests;

        }


        private void MyDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            string jsonSeria = JsonConvert.SerializeObject(propertyTests);
            File.WriteAllText("D:\\Рабочийстол\\Testik.json", jsonSeria);
            
        }

    }
}
