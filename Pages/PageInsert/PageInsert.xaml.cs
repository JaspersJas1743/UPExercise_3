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
    public partial class InsertM : Page
    {
        public InsertM() { InitializeComponent(); }
        
        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }

        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }

        private void InsertString(object sender, RoutedEventArgs e)
        {
            int index;
            try
            {
                index = Convert.ToInt32(stringIndex.Text);
                if (index < 0 || index > stringOne.Text.Length) { throw new Exception("Некорректно введен индекс"); }

                stringResult.Text = stringOne.Text.Insert(index, stringTwo.Text);
            } catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка преобразований", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void Drag(object sender, RoutedEventArgs e) { MainWindow.MouseDrug(); } 

        private void BackInsert(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }
    }
}