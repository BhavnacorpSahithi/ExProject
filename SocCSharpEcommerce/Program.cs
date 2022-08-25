using OrderEcommerceProject;
using ProductEcommerce;
using System;

namespace SocCSharpEcommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Customer cus = new Customer();
            OrderDetails ord = new OrderDetails();
            ProductDetails prod = new ProductDetails();

            
            void CustomerDetails()
            {
                Console.WriteLine("enter the customerid: ");
                cus.customerid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the customername: ");
                cus.customername = Console.ReadLine();
                Console.WriteLine("enter the customeraddress: ");
                cus.customeraddress = Console.ReadLine();
                Console.WriteLine("enter the customerphonenum: ");
                cus.customerphonenum = int.Parse(Console.ReadLine());
            }
            void DisplayCustomer()
            {
                Console.Write("customer id: " + cus.customerid);
                Console.Write("customer name: " + cus.customername);
                Console.Write("customer address: " + cus.customeraddress);
                Console.Write("customer phone num: " + cus.customerphonenum);
            }

            switch (n)
            {
                case 1:
                    CustomerDetails();
                    goto case 2;
                case 2:
                    DisplayCustomer();
                    break;
                case 3:
                    ord.OrderDetail();
                    goto case 4;
                case 4:
                    ord.DisplayOrders();
                    break;
                case 5:
                    prod.prodDetail();
                    goto case 6;
                case 6:
                    prod.Displayprods();
                    break;
              
            }

        }
    }
    //class Sum
    //{
    //    int i, j, m, n;
    //    int[,] a = new int[20, 20];
    //    public void get()
    //    {
    //        Console.WriteLine("Enter Row Value");
    //        m = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter Column Value");
    //        n = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter Elements one by one");
    //        for (i = 1; i <= m; i++)
    //        {
    //            for (j = 1; j <= n; j++)
    //            {
    //                a[i, j] = int.Parse(Console.ReadLine());
    //            }
    //        }
    //        Console.WriteLine("Given Matrix");
    //        for (i = 1; i <= m; i++)
    //        {
    //            for (j = 1; j <= n; j++)
    //            {
    //                Console.Write("\t{0}", a[i, j]);
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //    public void diagonal()
    //    {
    //        int d;
    //        d = 0;
    //        if (m == n)
    //        {
    //            for (i = 1; i <= m; i++)
    //            {
    //                for (j = 1; j <= n; j++)
    //                {
    //                    if (i == j)
    //                    {
    //                        d = d + a[i, j];
    //                    }
    //                    else if (i + j == n)
    //                    {
    //                        d = d + a[i, j];
    //                    }
    //                }
    //            }
    //            Console.WriteLine("Diagonal Sum= {0}", d);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Can't Perform Diagonal Sum");
    //        }
    //    }
    //    public void diagonal(int a, int b)
    //    {
    //        int temp;
    //        Console.WriteLine("the value of a:"+ a);
    //        Console.WriteLine("the value of b:"+ b);
    //        temp = a;
    //        a = b;
    //        b = temp;
    //        Console.WriteLine("the value of a:"+ a);
    //        Console.WriteLine("the value of b:"+ b);
    //    }
    //}
}
