using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class Footers
    {
        public int FootersID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ReservationContent { get; set; }
        public string TelephoneNumber { get; set; }
        public string WorkingDay { get; set; }
        public string WorkingHours { get; set; }
    }
}
