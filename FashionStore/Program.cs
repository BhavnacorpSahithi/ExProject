using Store;
using Store.Implementation;
using Store.Models;
using System;

namespace FashionStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Products ppl = new Products();
            Category cat = new Category();

            CategoryImp cr = new CategoryImp();
            Console.WriteLine("1 is search ");
            Console.WriteLine("2 is insert ");
            Console.WriteLine("3 is update ");
            Console.WriteLine("4 is delete ");

            ProductImp pr = new ProductImp();
            Console.WriteLine("5 is prodsearch ");
            Console.WriteLine("6 is prodinsert ");
            Console.WriteLine("7 is produpdate ");
            Console.WriteLine("8 is proddelete ");
            Console.WriteLine("9 is prodget ");

            Console.WriteLine("enter you choice: ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("welcome to search functionality ... ");
                    cr.search();
                    break;
                case 2:
                    Console.WriteLine("welcome to insert functionality ... ");
                    Action<Category> obj = new Action<Category>(cr.insert);
                    obj(cat);
                    break;
                case 3:
                    Console.WriteLine("welcome to update functionality ... ");
                    cr.update();
                    break;
                case 4:
                    Console.WriteLine("welcome to delete functionality ... ");
                    Func<int,int> del = new Func<int,int>(cr.delete);
                    int res = del(0);
                    break;
                case 5:
                    Console.WriteLine("welcome to prodsearch functionality ... ");
                    pr.search();
                    break;
                case 6:
                    Console.WriteLine("welcome to prodinsert functionality ... ");
                    Action<Products> obj1 = new Action<Products>(pr.insert);
                    obj1(ppl);
                    break;
                case 7:
                    Console.WriteLine("welcome to produpdate functionality ... ");
                    pr.update();
                    break;
                case 8:
                    Console.WriteLine("welcome to proddelete functionality ... ");
                    Func<int,int> pdel = new Func<int,int>(pr.delete);
                    int result = pdel(0);
                    break;
                case 9:
                    Console.WriteLine("welcome to getprod functionality ... ");
                    pr.getproduct();
                    break;
            }
        }
    }
}
