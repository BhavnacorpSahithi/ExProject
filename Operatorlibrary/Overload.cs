using System;
using System.Collections.Generic;
using System.Text;

namespace Operatorlibrary
{
    public class Overload
    {

    public int no1, no2;
        public Overload(int num1, int num2)
        {
            no1 = num1;
            no2 = num2;
        }
        public static Overload operator -(Overload c1)
        {
            c1.no1 = -c1.no1;
            c1.no2 = -c1.no2;
            return c1;
        }
        public void Print()
        {
            Console.WriteLine("Number1 = " + no1);
            Console.WriteLine("Number2 = " + no2);
        }
    }
}
