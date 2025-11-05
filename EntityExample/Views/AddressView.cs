using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExample.Views
{
    public class AddressView
    {
        public long ID_address { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string FullAddress
        {
            get
            {
                if (ID_address == -1)
                    return "Add";
                return $"{Street} {Number}, {City}, {Region}";
            }
        }
        public string Name { get; set; }
    }
}
