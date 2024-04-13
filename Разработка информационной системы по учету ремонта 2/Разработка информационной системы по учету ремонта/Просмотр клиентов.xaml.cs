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
    /// Логика взаимодействия для Просмотр_клиентов.xaml
    /// </summary>
    public partial class Просмотр_клиентов : Page
    {
        public Просмотр_клиентов()
        {
            InitializeComponent();
            Клиенты.ItemsSource = App.Database1Entities.Clients.ToList();
        }
    }
}
