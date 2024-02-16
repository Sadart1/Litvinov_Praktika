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
using WpfApp2;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Kategor.xaml
    /// </summary>
    public partial class Kategor : Window
    {
        public Kategor()
        {
            InitializeComponent();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tarelk tarelk = new Tarelk();
            tarelk.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Vilki vilki = new Vilki();
            vilki.Show();
        }
    }
}
