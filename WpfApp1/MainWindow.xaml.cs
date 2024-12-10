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

namespace Самомстоятельная
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int oshibki = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void proverit(object sender, RoutedEventArgs e)
        {
            if (text.Text == "Человек спит, какой вывод вы можете сделать? (Zzzzzzz)")
            {
                if (radio3.IsChecked == true)
                {
                    text.Text = "Как называется маленькая синяя баночка в фортнайте?";
                    radio1.Content = "Миник";
                    radio2.Content = "Gay-пати";
                    radio3.Content = "Синило";
                    radio4.Content = "Чага";
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
            else if (text.Text == "Как называется маленькая синяя баночка в фортнайте?")
            {
                if (radio1.IsChecked == true)
                {
                    text.Text = "Ты любишь мальчиков?";
                    radio1.Content = "Да";
                    radio2.Content = "Конечно";
                    radio3.Content = "Это база";
                    radio4.Content = "Люблю";
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
            else if (text.Text == "Ты любишь мальчиков?")
            {
                MessageBox.Show("Я так и знал");
                text.Text = "Играешь в доту?";
                radio1.Content = "Да";
                radio2.Content = "Каждый день";
                radio3.Content = "Обожаю";
                radio4.Content = "Нет";
            }
            else if (text.Text == "Играешь в доту?")
            {
                if (radio4.IsChecked == true)
                {
                    MessageBox.Show("Молодец");
                    MessageBox.Show($"Всего ошибок --> {oshibki}");
                    Close();
                }
                else
                {
                    MessageBox.Show("Гений, попробуй еще раз");
                    oshibki++;
                }
            }
        }
    }
}



