using System;
using System.Collections.Generic;

namespace ThreadsCS
{
    class Accounts
    {
        static void Main(string[] args)
        {
            Transactions tc = new Transactions(10000);         
            Update(tc);
        }
        static void Update(Transactions tc)
        {
         Console.WriteLine("enter y/n to continue");
            string repeat = Console.ReadLine();
            while (repeat == "y")
            {
                Console.WriteLine("1:credit");
                Console.WriteLine("2:debit");
                Console.WriteLine("3:transactions");

            choice: Console.WriteLine("enter the choice");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("ENTER THE CREDITED AMOUNT: ");
                        decimal amt = Convert.ToDecimal(Console.ReadLine());
                        // Thread t = new Thread(new ThreadStart(tc.CreditAmt(amt)));
                        // t.Start();
                        tc.CreditAmt(amt);
                        break;
                    case 2:
                        Console.WriteLine("ENTER THE debited AMOUNT: ");
                        decimal amt1 = Convert.ToDecimal(Console.ReadLine());
                        tc.DebitAmt(amt1);
                        break;
                    case 3:
                        tc.GetTransactions();
                        break;
                    default:
                        Console.WriteLine("invalid options");
                        goto choice;
                }
                Console.WriteLine("to continue-y/n-exit");
                 repeat = Console.ReadLine();
            }
        }
    }
    public class Transactions
    {
        private readonly object lockbalance = new object();
        private decimal balance;
        public Transactions(decimal initialBal) => balance = initialBal;
        List<decimal> total = new List<decimal>();
        public void CreditAmt(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "the creadited amount cant be negetive");
            }
            lock (lockbalance)
            {
                balance += amount;
                Console.WriteLine("balance=" + balance);
                total.Add(balance);
                Console.WriteLine("transaction of credied amount:" + total[1]);
            }
        }
        public decimal DebitAmt(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The debited amount can't be negetive");
            }
            decimal appliedamt = 0;
            lock (lockbalance)
            {
                if(balance >= amount)
                {
                    balance -= amount;
                    appliedamt = amount;
                    Console.WriteLine("balance"+balance);
                    total.Add(balance);
                    Console.WriteLine("transaction of debited amount:"+total[1]);
                }
            }
            return appliedamt;
        }
     
        public List<decimal> GetTransactions()
        {
            lock (lockbalance)
            {

                for (int i = 0; i < total.Count;i++)
                {
                    Console.WriteLine("Transaction: "+total[i]);
                }
            }
            return total;
        }
    }

}
