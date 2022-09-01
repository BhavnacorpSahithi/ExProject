using Store.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Interfaces
{
    public interface ICategory
    {
        void search();
        void insert(Category cat);
        void update();
        int delete(int id);
    }
}
