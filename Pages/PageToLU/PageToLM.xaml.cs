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
    public partial class ToM : Page
    {
        public ToM() { InitializeComponent(); }

        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }

        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }
        
        private void ToLUString(object sender, RoutedEventArgs e)
        {
            stringOne.Text = stringResult.Text.ToLower();
            stringTwo.Text = stringResult.Text.ToUpper();
        }

        private void Drag(object sender, RoutedEventArgs e) { MainWindow.MouseDrug(); } 

        private void BackToM(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }
    }
}