using Franchise;
using Franchise.Def;
using Franchise.Model;
using System;

namespace Assessment5CS
{
    class Program
    {
        static void Main(string[] args)
        {

                FranchiseImp cr = new FranchiseImp();
            Franchise1 cat = new Franchise1();
            Console.WriteLine("1 is franchise login");
            Console.WriteLine("2 is franchise delete emp ");
            Console.WriteLine("3 is admin login ");
            Console.WriteLine("4 is admin delete ");
            Console.WriteLine("5 is get total sales");

            //product
            AdminImp pr = new AdminImp();
            Admin ppl = new Admin();
            Console.WriteLine("6 is employee insert ");
            Console.WriteLine("7 is franchise insert ");
            Console.WriteLine("8 is salary distribution");
            Console.WriteLine("9 is pizza details");

            Console.WriteLine("enter you choice: ");
            int n = int.Parse(Console.ReadLine());

          
                switch (n)
                {
                    case 1:
                        Console.WriteLine("welcome to franchise login functionality ... ");
                        cr.loginuser();
                        goto case 6;
                    case 2:
                        Console.WriteLine("welcome to delete functionality ... ");
                        cr.delete();
                        break;
                    case 3:
                        Console.WriteLine("welcome to admin login functionality ... ");
                        pr.loginadmin();
                        goto case 7;
                    case 4:
                        Console.WriteLine("welcome to delete functionality ... ");
                        pr.delete();
                        break;
                    case 5:
                        Console.WriteLine("welcome to get all functionality ... ");
                        pr.gettotalsales();
                        break;
                    case 6:
                        Console.WriteLine("welcome to franchise login functionality ... ");
                        cr.insert();
                        break;
                    case 7:
                        Console.WriteLine("welcome to admin insert functionality ... ");
                        pr.insert();
                        break;
                    case 8:
                        Console.WriteLine("welcome to salary distribution functionality ... ");
                        pr.salarydistribution();
                        break;
                    case 9:
                        Console.WriteLine("welcome to pizza details functionality ... ");
                        cr.getpizzadetails();
                        break;
                    default:
                        Console.WriteLine("invalid options... ");
                        break;

                }
            
        }
    }
}
