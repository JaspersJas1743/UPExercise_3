using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Exercise3
{
    public partial class IndexOfM : Page
    {
        public IndexOfM() { InitializeComponent(); }

        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }

        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }
        
        private void IndexOfString(object sender, RoutedEventArgs e)
        {
            if (stringOne.Text.IndexOf(stringTwo.Text) >= 0) {
                stringResult.Text =  $"Первое вхождение подстроки \"{stringTwo.Text}\" начинается с {stringOne.Text.IndexOf(stringTwo.Text)} элемента строки \"{stringOne.Text}\"";
                stringResult.Text += $"\nПоследнее вхождение подстроки \"{stringTwo.Text}\" начинается с {stringOne.Text.LastIndexOf(stringTwo.Text)} элемента строки \"{stringOne.Text}\"";
            }
            else { stringResult.Text = $"Подстрока \"{stringTwo.Text}\" не существует в строке \"{stringOne.Text}\""; }
        }

        private void Drag(object sender, RoutedEventArgs e) { MainWindow.MouseDrug(); } 

        private void BackIndexOf(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }
    }
}