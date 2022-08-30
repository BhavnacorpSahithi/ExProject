using System;

namespace ConsoleAdo
{
  
    class Program
    {
        static void Main(string[] args)
        {
            functionality pr = new functionality();
            Console.WriteLine("1 is search ");
            Console.WriteLine("2 is insert ");
            Console.WriteLine("3 is update ");
            Console.WriteLine("4 is delete ");

            Console.WriteLine("enter you choice: ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("welcome to search functionality ... ");
                    pr.search();
                    break;
                case 2:
                    Console.WriteLine("welcome to insert functionality ... ");
                    pr.insert();
                    break;
                case 3:
                    Console.WriteLine("welcome to update functionality ... ");
                    pr.update();
                    break;
                case 4:
                    Console.WriteLine("welcome to delete functionality ... ");
                    pr.delete();
                    break;
            }
          
        }
        

    }
}
