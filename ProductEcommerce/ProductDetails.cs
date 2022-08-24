
using System;

namespace ProductEcommerce
{
    public class ProductDetails
    {
        Product prod = new Product();
      public  void prodDetail()
        {
            Console.WriteLine("enter theProdid: ");
            prod.Prodid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the ProdName: ");
            prod.ProdName = Console.ReadLine();
            Console.WriteLine("enter the ProdAmount: ");
            prod.ProdAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the AvilableQty: ");
            prod.AvilableQty = int.Parse(Console.ReadLine());            
        }
       public void Displayprods()
        {
            Console.Write("prodProdid: " + prod.Prodid);
            Console.Write(" prod prodedCusName: " + prod.ProdName);
            Console.Write(" prod proditem: " + prod.ProdAmount);
            Console.Write(" prod prodamount: " + prod.AvilableQty);
           
        }
    }
}
