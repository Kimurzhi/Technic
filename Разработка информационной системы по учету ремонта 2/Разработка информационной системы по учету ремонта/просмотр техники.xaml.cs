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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Разработка_информационной_системы_по_учету_ремонта
{
    /// <summary>
    /// Логика взаимодействия для просмотр_техники.xaml
    /// </summary>
    public partial class просмотр_техники : Page
    {
        public просмотр_техники()
        {
            InitializeComponent();
            Technic.AutoGenerateColumns = false;
            Technic.ItemsSource = App.Database1Entities.Technic.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
