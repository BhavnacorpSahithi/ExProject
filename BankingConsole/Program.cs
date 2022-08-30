using LibraryModel;
using System;

namespace BankingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Crud cr = new Crud();
            Console.WriteLine("1 is login ");
            Console.WriteLine("2 is delete ");


            Console.WriteLine("enter you choice: ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            { 
              
                case 1:
                    Console.WriteLine("welcome to login functionality ... ");
                    cr.loginuser();
                    break;
                case 2:
                    Console.WriteLine("welcome to delete functionality ... ");
                    cr.delete();
                    break;
                default:
                    Console.WriteLine("..........................................");
                    break;
            }
        }
    }
}
