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
using System.Diagnostics.Eventing.Reader;

namespace WpfApp1
{
    public partial class MAIN : Page, INotifyPropertyChanged
    {
        private string searchText = "";
        public MAIN()
        {
            InitializeComponent();
            DataContext = this;
            Search();
        }
        void Signal(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Person> Persons { get; set; }

        public Person Selected_Person { get; set; }

        public string SearchText { get => searchText; set { searchText = value; Search(); } }


        public void Search()
        {
            var result = DB.Instance.Person.
                Include(s => s.IdroomNavigation).Where(s =>
                s.IdroomNavigation.Room1.Contains(searchText) || s.Pasportinfo.Contains(searchText) || s.Departuredate.Contains(searchText) || s.Surname.Contains(searchText) ||
                s.Arrivaldate.Contains(searchText) || s.Firstname.Contains(searchText) || s.Lastname.Contains(searchText) || s.Phone.Contains(searchText));
            Persons = result.ToList();
            Signal(nameof(Persons));

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            add add = new add();
            NavigationService.Navigate(add);
        }
        private void Red_Click(object sender, RoutedEventArgs e)
        {
 
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
