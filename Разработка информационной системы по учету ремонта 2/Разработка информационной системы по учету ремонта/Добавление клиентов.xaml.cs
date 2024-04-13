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
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace Разработка_информационной_системы_по_учету_ремонта
{
    byte[] bytes;
    /// <summary>
    /// Логика взаимодействия для Добавление_клиентов.xaml
    /// </summary>
    public partial class Добавление_клиентов : Page
    {
private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите фото!";
            openFileDialog.Filter = "All supported graphics | *.jpg;*.png;*.jpeg|";
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                bytes = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                Photo.Source = bitmapImage;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Surname.Text == "" || Name.Text == "" || FutherName == "" || Adres.Text == "" || DeriveBytes == null)
            {
                MessageBox.Show("Необходимо заполнить все поля!", "Внимание!" ,MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        public Добавление_клиентов()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
