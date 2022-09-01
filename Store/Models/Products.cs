using Store.Models;
using System;

namespace Store
{
    public class Products : Category
    {
        public int Price { get; set; }
        public int Quantity { get; set; }

        public int cat_id { get; set; }

    }
}
