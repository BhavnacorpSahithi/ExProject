using System;
using System.Collections.Generic;
using System.Text;

namespace SocCSharpEcommerce
{
    public static class ExClass
    {
        static int number=int.Parse(Console.ReadLine());
        static int result=0;
        static int reminder;
        static int temp = number;

        public static void Armstrong()
        {
            while (number > 0)
            {
                reminder = number % 10;
                result = result + (reminder * reminder * reminder);
                number = number / 10;
            }

            if(temp == result)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong");
            }
        }
    }
    class StructExamples
    {
        public struct Employee
        {
            public int EmpId;
            public string Empname;
            public string Gender;
            public int PhoneNum;

        }
        static void Main(string[] args)
        {
            ExClass.Armstrong();

            Employee[] emp = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Name of the employee : ");
                emp[i].EmpId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input day of the birth : ");
                emp[i].Empname = Console.ReadLine();

                Console.Write("Input month of the birth : ");
                emp[i].Gender = Console.ReadLine();

                Console.Write("Input year for the birth : ");
                emp[i].PhoneNum = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter the value of empid: " + emp[i].EmpId);
                Console.WriteLine("enter the value of gender: " + emp[i].Empname);
                Console.WriteLine("enter the value of gender: " + emp[i].Gender);
                Console.WriteLine("enter the value of gender: " + emp[i].PhoneNum);
                Console.ReadLine();
            }
        }
        }
}
