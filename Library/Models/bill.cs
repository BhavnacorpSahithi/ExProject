using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class bill:Common
    {
       public int bill_no { get; set; }
       public int doctor_charge { get; set; }
       public int room_charge { get; set; }
       public int no_of_days { get; set; }
       public int lab_charge { get; set; }
       public int totalbill { get; set; } 
    }
}
