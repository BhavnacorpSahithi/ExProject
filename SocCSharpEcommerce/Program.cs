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
}
