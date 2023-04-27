using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Drawing;
using System.IO;
using System.Security.RightsManagement;
using System.Windows.Interop;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public string login {get; set;}
        public string password { get; set; }

        public int EnterCount;
        public string ErrorText { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Logo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)

        {
            if (tb2.Password.Length > 0)
            {
                WaterMark.Visibility = Visibility.Collapsed;
            }
            else
            {
                WaterMark.Visibility = Visibility.Visible;
            }
        }
        public void ChekAuth(string login, string password)
        {
            ErrorText = null;

            var user  = DB.Instance.Users.Include(s => s.IdroleNavigation).FirstOrDefault(s => s.Login == login & s.Password == password);
            if (user != null)
            {
                Window1 window1 = new Window1();
                window1.Show();
                Hide();
            }
            else if (user == null)
            {
                EnterCount++;

                if (EnterCount > 1)
                    MessageBox.Show("Неправильный логин или пароль!");

            }
            else if(WaterMark ==  null)
            {
                MessageBox.Show("Вы не ввели логин, или пароль!");
            }
            else if (Login == null)
            {
                MessageBox.Show("Вы не ввели логин, или пароль!");
            }


        }
        private void Auth_Button(object sender, RoutedEventArgs e)
        {
            ChekAuth(login, tb2.Password);
        }
    }
}
