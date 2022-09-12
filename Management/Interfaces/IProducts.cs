using Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Interfaces
{
    public interface IProducts
    {

        void prod_insert();
        void prod_update();
        void prod_delete();

        void get_Stafftimings();

    }
}
