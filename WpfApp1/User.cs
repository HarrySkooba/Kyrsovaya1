using System;
using System.Collections.Generic;

namespace WpfApp1
{
    public partial class User
    {
        public int Userid { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Idrole { get; set; }

        public virtual Role IdroleNavigation { get; set; }
    }
}
