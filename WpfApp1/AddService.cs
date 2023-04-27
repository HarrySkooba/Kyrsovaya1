using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp1
{
    public partial class AddService
    {
        public int Serviceid { get; set; }
        public bool? Breakfast { get; set; }
        public bool? Dinner { get; set; }
        public bool? Lunch { get; set; }
        public bool? Spa { get; set; }
        public bool? Laundry { get; set; }
        public int Idperson { get; set; }



        public virtual Person IdpersonNavigation { get; set; }
    }
}
