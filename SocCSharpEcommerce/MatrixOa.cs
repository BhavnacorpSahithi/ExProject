using System;
using System.Collections.Generic;
using System.Text;

namespace SocCSharpEcommerce
{
   public class MatrixOa
    {
       public static void Main(string[] args)
        {
            Sum ma = new Sum();
            ma.get();
            ma.diagonal();
            ma.diagonal(10, 20);
            Console.Read();
        }
    }
   public class Sum
    {
        int i, j, m, n;
        int[,] a = new int[20, 20];
        public void get()
        {
            Console.WriteLine("Enter Row Value");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column Value");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Elements one by one");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Given Matrix");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void diagonal()
        {
            int d;
            d = 0;
            if (m == n)
            {
                for (i = 1; i <= m; i++)
                {
                    for (j = 1; j <= n; j++)
                    {
                        if (i == j)
                        {
                            d = d + a[i, j];
                        }
                        else if (i + j == n)
                        {
                            d = d + a[i, j];
                        }
                    }
                }
                Console.WriteLine("Diagonal Sum= {0}", d);
            }
            else
            {
                Console.WriteLine("Can't Perform Diagonal Sum");
            }
        }
        public void diagonal(int a, int b)
        {
            int temp;
            Console.WriteLine("the value of a:", a);
            Console.WriteLine("the value of b:", b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("the value of a:", a);
            Console.WriteLine("the value of b:", b);
        }

    }

}
