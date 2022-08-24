
using System;

namespace OrderEcommerceProject
{
    public class OrderDetails
    {
        Order order = new Order();
      public  void OrderDetail()
        {
            Console.WriteLine("enter the Orderid: ");
            order.Orderid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the OrderedCusName: ");
            order.OrderedCusName = Console.ReadLine();
            Console.WriteLine("enter the Orderitem: ");
            order.Orderitem = Console.ReadLine();
            Console.WriteLine("enter the Orderamount: ");
            order.Orderamount = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Orderqty: ");
            order.Orderqty = int.Parse(Console.ReadLine());
            order.totalprice = order.Orderamount * order.Orderqty;
        }
       public void DisplayOrders()
        {
            Console.Write("order Orderid: " + order.Orderid);
            Console.Write(" order OrderedCusName: " + order.OrderedCusName);
            Console.Write(" order Orderitem: " + order.Orderitem);
            Console.Write(" order Orderamount: " + order.Orderamount);
            Console.Write(" order Orderqty: " + order.Orderqty);
            Console.Write(" order totalprice: " + order.totalprice);
        }
    }
}
