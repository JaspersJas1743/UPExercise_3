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
    public partial class EqualsM : Page
    {
        public EqualsM() { InitializeComponent(); }
        
        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }

        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }

        private void EqualsString(object sender, RoutedEventArgs e) { stringResult.Text = (stringOne.Text.Equals(stringTwo.Text) == true) ? $"Строка \"{stringOne.Text}\" равна строке \"{stringTwo.Text}\"" : $"Строка \"{stringOne.Text}\" не равна строке \"{stringTwo.Text}\""; }

        private void Drag(object sender, RoutedEventArgs e) { MainWindow.MouseDrug(); } 
        
        private void BackEquals(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }
    }
}