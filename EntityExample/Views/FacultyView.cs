using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample.Views
{
    public class FacultyView
    {
        public long ID_faculty { get; set; }
        public string Name { get; set; }
        public Nullable<long> ID_address { get; set; }
        public Nullable<System.DateTime> ANNO { get; set; }
        public Address Address { get; set; }
    }
}
