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
    public partial class ContainsM : Page
    {
        public ContainsM() { InitializeComponent(); }

        private void BackContains(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }

        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }

        private void ContainsString(object sender, RoutedEventArgs e) { stringResult.Text = (stringOne.Text.Contains(stringTwo.Text) == true) ? $"Строка \"{stringTwo.Text}\" содержится в \"{stringOne.Text}\"" : $"Строка \"{stringTwo.Text}\" не содержится в \"{stringOne.Text}\""; }

        private void Drag(object sender, RoutedEventArgs e) { MainWindow.MouseDrug(); } 
        
        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }
    }
}