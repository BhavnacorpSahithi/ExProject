using Management.Implementation;
using System;
using System.Data.SqlClient;
using System.IO;

namespace Assessment6CS
{
    class Program
    {
        static void Main(string[] args)
        {
            StaffImp ct = new StaffImp();
            ProductImp prd = new ProductImp();

            Console.WriteLine("to enter y or n");
            string repeat = Console.ReadLine();

            while (repeat == "y")
            {
                Console.WriteLine("1:staff insert");
                Console.WriteLine("2:staff delete");
                Console.WriteLine("3:staff update");
                Console.WriteLine("4:staff salary");

                Console.WriteLine("4:product insert");
                Console.WriteLine("5:product delete");
                Console.WriteLine("6:product update");
                Console.WriteLine("8:product get");
                Console.WriteLine("8:product search");


            choice: Console.WriteLine("enter ur choice");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        ct.staff_insert();
                      
                        break;
                    case 2:
                        ct.staff_delete();
                        break;
                    case 3:
                        ct.staff_update();
                        break;
                    case 4:
                        ct.staff_salary();
                        break;
                    case 5:
                        prd.prod_insert();
                        break;
                    case 6:
                        prd.prod_delete();
                        break;
                    case 7:
                        prd.prod_update();
                        break;
                    case 8:
                        prd.get_Stafftimings();
                        break;
                    case 9:
                        prd.prod_search();
                        break;
                    default:
                        Console.WriteLine("invalid options");
                        goto choice;
                }
                Console.WriteLine("do u want to continue y/n");
                repeat = Console.ReadLine();
            }
        }
    }
}


























