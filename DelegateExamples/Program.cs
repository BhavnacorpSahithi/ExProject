using System;

namespace DelegateExamples
{
    class Program
    {
        //define a delegate
        public delegate void palindromedel(int x);

        public void palindrome(int x)
        {
            int temp = x;
            int result = 0;
            int reminder = 0;

            while (x > 0)
            {
                reminder = x % 10;
                result = (result * 10) + reminder;
                x = x / 10;
            }
            if(temp == result)
            {
                Console.WriteLine("number is palindrome"+ temp);
            }
            else
            {
                Console.WriteLine("number is not palindrome:"+ temp);
            }

        }
        
        static void Main(string[] args)
        {
            Program pr = new Program();
            palindromedel pd = new palindromedel(pr.palindrome);
            pd(12321);
        }
    }
}
