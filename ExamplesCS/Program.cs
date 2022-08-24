using System;

namespace ExamplesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int stuId=0, stuClass=0;
            string stuName="", stuTeacherName="";

            Console.WriteLine("enter the value of n");
            n = int.Parse(Console.ReadLine());

            //---------------------------------------
            int number = 12321, reversenum = 0,result;
            int originalnum = number;
            while (number != 0)
            {
                result = number % 10;
                reversenum = reversenum * 10 + result;
                number /= 10;
            }
            //-----------------------------------------
            double area = 0;
            double radius = 0;
            double height = 0;

            //creating object to class.
            Cone C = new Cone();

            Console.Write("Enter the radius of a cone: ");
            radius = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of a cone: ");
            height = double.Parse(Console.ReadLine());

            area = C.AreaofCone(radius, height);


            switch (n)
            {
                case 1:
                    Console.Write("enter the value of studentid:");
                    stuId = int.Parse(Console.ReadLine());
                    Console.Write("enter the value of student class:");
                    stuClass = int.Parse(Console.ReadLine());
                    Console.Write("enter the value of student name:");
                    stuName = Console.ReadLine();
                    Console.Write("enter the value of teacher name:");
                    stuTeacherName = Console.ReadLine();
                    goto case 2;
                case 2:
                    Console.WriteLine("stuid:"+ stuId);
                    Console.WriteLine("stuClass:" + stuClass);
                    Console.WriteLine("stuName:" + stuName);
                    Console.WriteLine("stuTeacherName:" + stuTeacherName);
                    break;
                case 3:
                    Console.WriteLine("case 3 not working");
                    if (originalnum == reversenum)
                    {
                        Console.WriteLine("the number is palindrome: "+ originalnum);
                    }
                    else
                    {
                        Console.WriteLine("the number is not palindrome: "+ originalnum);
                    }
                    break;
                case 4:
                    Console.WriteLine("Area of cone is: " + area);
                    break;
            }
        }
    }
    class Cone
    {
        public double AreaofCone(double radius, double height)
        {
            double area = 0.0;

            area = Math.PI * radius * (radius + Math.Sqrt(radius * radius + radius * radius));

            return area;
        }
    }
}
