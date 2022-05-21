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
    public partial class Menu : Page
    {
        public Menu() { InitializeComponent(); }
        private void ToMethod(object sender, RoutedEventArgs e)
        {
            object? toPage = null;
            if (ContainsMethod.IsChecked == true) { toPage = new ContainsM(); }
            else if (EqualsMethod.IsChecked == true) { toPage = new EqualsM(); }
            else if (ConcatMethod.IsChecked == true) { toPage = new ConcatM(); }
            else if (RemoveMethod.IsChecked == true) { toPage = new RemoveM(); }
            else if (StartsWithMethod.IsChecked == true) { toPage = new StartsWithM(); }
            else if (EndsWithMethod.IsChecked == true) { toPage = new EndsWithM(); }
            else if (IndexOfMethod.IsChecked == true) { toPage = new IndexOfM(); }
            else if (InsertMethod.IsChecked == true) { toPage = new InsertM(); }
            else if (JoinMethod.IsChecked == true) { toPage = new JoinM(); }
            else if (ReplaceMethod.IsChecked == true) { toPage = new ReplaceM(); }
            else if (SplitMethod.IsChecked == true) { toPage = new SplitM(); }
            else if (SubstringMethod.IsChecked == true) { toPage = new SubstringM(); }
            else if (ToM.IsChecked == true) { toPage = new ToM(); }
            NavigationService.Navigate(toPage);
        }

        private void Drag(object sender, RoutedEventArgs e) { MainWindow.MouseDrug(); } 

        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }

        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }
    }
}