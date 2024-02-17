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
using Microsoft.EntityFrameworkCore;
using WpfApp2;

namespace WpfApp1
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
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var login = loginn.Text;
            var password = passs.Text;
            var context = new AppDbContext();
            var user_exists = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password) ;
            if (user_exists == null)
            {
                MessageBox.Show("Не ну ты ваще");
                return;
            }
            context.Korzi.RemoveRange(context.Korzi);
            context.SaveChanges();
            MessageBox.Show("Харооош, ты вошел");
            this.Hide();
            Kategor kategor = new Kategor();
            kategor.Show();
        }
    }
}
