using Microsoft.Data.SqlClient;
using Noisy.DataBase;
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

namespace Noisy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            
                DragMove();
          
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text;
            string password = PasswordTb.Password;
            NoisyDbContext context = new NoisyDbContext();

            User user = context.Users.FirstOrDefault(x => x.Login == login);
            if (user == null)
            {
                MessageBox.Show("Wrong Username"); ;
                return;
            }
            if (user.Password != password)
            {
                MessageBox.Show("Wrong Password. "); ;
            }


            
             (new Window2()).Show();

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LoginTb_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    
    }
}
