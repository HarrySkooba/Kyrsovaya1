using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp1
{
    public partial class Users
    {
        public int Userid { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Idrole { get; set; }

        public virtual Role IdroleNavigation { get; set; }
    }
}
