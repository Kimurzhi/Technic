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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "" || Password.Password == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                App.Database1Entities.Admins.Single(x => x.Login == Login.Text & x.Password == Password.Password);
                Window1 window = new Window1();
                window.Show();
                Close();
            }

            catch
            {
                MessageBox.Show("Неверно введён логин или пароль!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

