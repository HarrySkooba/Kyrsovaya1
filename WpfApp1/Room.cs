using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp1
{
    public partial class Room
    {
        public Room()
        {
            Person = new HashSet<Person>();
        }

        public int Roomid { get; set; }
        public bool Status { get; set; }
        public string Room1 { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
