using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExamples
{
    class generic
    {
        static void Main(string[] args)
        {
            generic gr = new generic();
            Func<int, int> obj = new Func<int, int>(gr.armstrong);
            int output = obj(153);

            Action<int> obj1 = new Action<int>(gr.primenum);
            obj1(7);

            Predicate<string> obj2 = new Predicate<string>(gr.validate);
            bool result = obj2("");
            Console.WriteLine("predicate: "+result);
        }
        //generic delegate predicate
        List<string> str = new List<string>()
        {
            new string("Monday"),
            new string("Tuesday"),
            new string("Wednesday"),
            new string("Thursday"),
            new string("Friday"),

        };

        public bool validate(string res)
        {
            if (str.Count <= 5)
            { return true; }
            else
            {
                return false;
            }
        }
        //generic delegate Action
        public void primenum(int num)
        {
           int k = 0;
            for(int i = 1;i <= num; i++)
            {
                if( num % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine("Action-the number {0} is prime number and the largest factorial is {1}", num, k);
            }
            else
            {
                Console.WriteLine("Action-the number is not prime");
            }
        }
        //generic delegate Func
        public int armstrong(int number)
        {
            int temp = number;
            int result = 0;
            int reminder = 0;
            while (number > 0)
            {
                reminder = number % 10;
                result = result + (reminder * reminder * reminder);
                number = number / 10;
            }
            if(temp == result)
            {
                Console.WriteLine("Func-the num is armstrong"+temp);
            }
            else
            {
                Console.WriteLine("Func-the num is armstrong" + temp);
            }
            return result;
        }
       
    }
}
