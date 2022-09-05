using System;
using System.Collections.Generic;
using System.Text;

namespace Franchise.Model
{
    public class Admin
    {
        public int admin_id { get; set; }
        public int f1_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int total_sales { get; set; }
        public string role { get; set; }
        public string franchise_name { get; set; }
        public string franchise_branch { get; set; }
    }
}
