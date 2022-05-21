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
    public partial class RemoveM : Page
    {
        public RemoveM() { InitializeComponent(); }
        
        private void Exit(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }

        private void RemoveString(object sender, RoutedEventArgs e)
        {
            int count = -1, index;
            try
            {
                try
                {
                    index = Convert.ToInt32(stringIndex.Text);
                    if (index < 0 || index > stringOne.Text.Length) { throw new Exception(); }
                } catch { throw new Exception("Некорректно введен индекс"); }
                if (stringCount.Text != "")
                {
                    try
                    {
                        count = Convert.ToInt32(stringCount.Text);
                        if (count < 0) { throw new Exception(); }
                    } catch { throw new Exception("Некорректно введено количество символов для удаления"); }
                }
                stringResult.Text = count < 0 ? stringOne.Text.Remove(index) : stringOne.Text.Remove(index, count);
            } catch(Exception ex) { MessageBox.Show(ex.Message, "Ошибка преобразования", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void Drag(object sender, RoutedEventArgs e) { MainWindow.MouseDrug(); } 

        private void Deact(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }
        
        private void BackRemove(object sender, RoutedEventArgs e) { NavigationService.Navigate(new Menu()); }
    }
}