using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp1
{
    public partial class Person
    {
        public Person()
        {
            AddService = new HashSet<AddService>();
        }

        public int Personaid { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Arrivaldate { get; set; }
        public string Departuredate { get; set; }
        public int? Amountofchildren { get; set; }
        public int? Numberofadults { get; set; }
        public string Addition { get; set; }
        public string Pasportinfo { get; set; }
        public int Idroom { get; set; }

        public virtual Room IdroomNavigation { get; set; }
        public virtual ICollection<AddService> AddService { get; set; }
    }
}
