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

namespace Разработка_информационной_системы_по_учету_ремонта
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TechnicView_Click(object sender, RoutedEventArgs e)
        {
    frame.Navigate(new Uri("Просмотр техники.xaml"), UriKind.Relative);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("Добавление техники.xaml"), UriKind.Relative);
        }
    }
}
