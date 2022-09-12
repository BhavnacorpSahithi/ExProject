using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Models
{
    public class Staff
    {
        public int Staff_id { get; set; }
        public string Staff_Name { get; set; }
        public string Dept { get; set; }
        public long Salary { get; set; }

        public string username { get; set; }
        public string password { get; set; }
        public int Sid { get; set; }
        public int No_of_days { get; set; }

        public string role { get; set; }


    }
}
