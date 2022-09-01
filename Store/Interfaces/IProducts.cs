using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Interfaces
{
    public interface IProducts
    {
        void search();
        void getproduct();

        void insert(Products ppl);
        void update();
        int delete(int id);

    }
}
