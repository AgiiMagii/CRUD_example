using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample.Views
{
    public class LectorView
    {
        public long ID_lector { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<long> ID_address { get; set; }

    }
}
