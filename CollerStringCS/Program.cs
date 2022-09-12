using System;
using System.Runtime.CompilerServices;

namespace CollerStringCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nenter y / n");
            string repeat = Console.ReadLine();

            while (repeat == "y")
            {
                Console.WriteLine("1:tuple");
                Console.WriteLine("2:callers");
                Console.WriteLine("3:indexer");
                Console.WriteLine("4:exit");

            choice: Console.WriteLine("\nenter ur choice:");
                int n = int.Parse(Console.ReadLine());


                switch (n)
                {

                    case 1:
                        var variables = new Tuple<int, string, long, string>(1, "bhavna", 4567367, "B+");
                        Console.WriteLine("id:{0} name:{1} mobile:{2} b-group:{3}", variables.Item1, variables.Item2, variables.Item3, variables.Item4);
                        break;
                    case 2:
                        Program.callersfunc();
                        break;
                    case 3:
                        Example<int> ex = new Example<int>();
                        ex[0] = 10;
                        ex[1] = 20;
                        ex[2] = 30;
                        ex[3] = 40;
                        ex[4] = 50;
                        ex[5] = 60;
                        ex[6] = 70;
                        ex[7] = 80;
                        ex[8] = 90;
                        ex[9] = 100;
                        Console.Write($"the array is:{0}={ex[0]},{1}={ex[1]},{2}={ex[2]},{3}={ex[3]},{4}={ex[4]},{5}={ex[5]},{6}={ex[6]},{7}={ex[7]},{8}={ex[8]},{9}={ex[9]}");
                        break;
                    default:
                        Console.WriteLine("invalid options");
                        Environment.Exit(0);
                        break;
                        goto choice;

                }
                Console.WriteLine("\ncontinue y / n");
                repeat = Console.ReadLine();

            }

        }
        //callers attribute
        static void callersfunc([CallerMemberName] string name = null,[CallerFilePath] string path = null)
        {
            Console.WriteLine($"name:{name}");
            Console.WriteLine($"file path:{path}");
        }
    }
    //indexer
    class Example<T>
    {
        private T[] t = new T[10];
        public T this[int i]
        {
            get { return t[i]; }
            set { t[i] = value; }
        }
    }
}
