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
using WpfApp1;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Korzina.xaml
    /// </summary>
    public partial class Korzina : Window
    {
        public Korzina()
        {
            InitializeComponent();
            var context = new AppDbContext();
            var allRecords = context.Korzi.ToList();
            lb.ItemsSource = allRecords;
            var summa = context.Korzi.Select(x => x.price).ToList();
            var sum = summa.Sum();
            tb.Text = "Сумма заказа: " + sum + " руб";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Kategor kategor = new Kategor();
            kategor.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var context = new AppDbContext();
            context.Korzi.RemoveRange(context.Korzi);
            context.SaveChanges();
            var allRecords = context.Tovar.ToList();
            lb.ItemsSource = allRecords;

        }

        private void but_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
