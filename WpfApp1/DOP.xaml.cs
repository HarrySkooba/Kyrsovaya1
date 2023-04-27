using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
   
    public partial class DOP : Page, INotifyPropertyChanged
    {
        private string searchText = "";
        public DOP()
        {
            InitializeComponent();
            DataContext = this;
            Search();
        }
        void Signal(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public event PropertyChangedEventHandler PropertyChanged;

        public List<AddService> AddServices { get; set; }

        public Person Selected_AddService { get; set; }

        public string SearchText { get => searchText; set { searchText = value; Search(); } }


        public void Search()
        {
            var result = DB.Instance.AddService;
            AddServices = result.ToList();
            Signal(nameof(AddServices));
        }

        private void bf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void spa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lunch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void laundry_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dinner_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
