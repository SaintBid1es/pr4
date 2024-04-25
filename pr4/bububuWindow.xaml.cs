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
using System.Windows.Shapes;
using System.IO;
using System.Text.Json;
using static MaterialDesignThemes.Wpf.Theme;
using Newtonsoft.Json;

namespace pr4
{
    /// <summary>
    /// Логика взаимодействия для Window.xaml
    /// </summary>
    public partial class bububuWindow : Window
    {
        private Page1 editor;
        private Page2 executor;
        List<PropertyTest> propertyTests = new List<PropertyTest>();
        public bububuWindow(bool needRedactor)
        {
            executor = new Page2();
            editor = new Page1();
            InitializeComponent();
            Pages.Content = editor;
            Redactor_Testa.IsEnabled = needRedactor;


        }
        private void Redactor_Click(object sender, RoutedEventArgs e)
        {
            Pages.Content = editor;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ShowActivatedProperty = new MainWindow();
            ShowActivatedProperty.Show();
            Close();
        }

        private void Take_the_test_Click(object sender, RoutedEventArgs e)
        {
            string text = string.Empty;
            text = File.ReadAllText("D:\\Рабочийстол\\Testik.json");
            List<PropertyTest> result = JsonConvert.DeserializeObject<List<PropertyTest>>(text);
            executor.TextNameBlock.Text = result[0].Name;
            executor.TextDescriptionBlock.Text = result[0].Description;
            executor.knopka1.Content = result[0].First_variant;
            executor.knopka2.Content = result[0].Two_variant;
            executor.knopka3.Content = result[0].Three_variant;
            Pages.Content = executor;
            
        }
    }
}
