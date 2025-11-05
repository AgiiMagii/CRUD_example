using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample.Views
{
    public class StudentView
    {
        public long ID_student { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> BirthYear { get; set; }
        public string CourseName { get; set; }
    }
}
