using System;
using System.Collections.Generic;

namespace ExRevision
{
    class Program : BaseClass
    {
        public override void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public override void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public override void mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        //Object
       
        static void Main(string[] args)
        {
            List<Object> obj = new List<object>();
            obj.Add("first set: ");

            for (int j = 0; j < 5; j++)
            {
                obj.Add(j);
            }

            Program pr = new Program();
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                pr.add(10, 20);
                    break;
                case 2:
                pr.sub(50, 20);
                    break;
                case 3:
                    pr.mul(10, 20);
                    break;
                case 4:
                    pr.div(10, 20);
                    break;
                case 5:
                    foreach (object obj1 in obj)
                    {
                        Console.WriteLine(obj1);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            
        }
    }
    public abstract class BaseClass
    {
        public abstract void add(int x,int y);
        public abstract void sub(int x, int y);
        public abstract void mul(int x, int y);
        public abstract void div(int x, int y);

    }
    
}
