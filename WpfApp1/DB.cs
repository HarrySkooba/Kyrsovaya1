using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class DB
    {

        static sanatoriyContext instance;
        public static sanatoriyContext Instance
        {
            get
            {
                if (instance == null)
                    instance = new sanatoriyContext();
                return instance;
            }
        }

    }
}
