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
            var context = new AppDbContext();
            var allRecords = context.Tovar.ToList();
            lb.ItemsSource = allRecords;
            
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            var context = new AppDbContext();
            var aa = context.Tovar.SingleOrDefault(x => x.id == lb.SelectedIndex + 1);


            if (aa != null)
            {
                var b = new Korz { name = aa.name, image = aa.image, kratkoe_opis = aa.kratkoe_opis, opis = aa.opis, price = aa.price };
                context.Korzi.Add(b);
            }
            context.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Korzina korzina = new Korzina();
            korzina.Show();
        }
    }
}
