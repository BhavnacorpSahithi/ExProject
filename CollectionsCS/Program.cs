using System;
using System.Collections.Generic;
using System.Collections;


namespace CollectionsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> emp = new List<Employee>();
            //emp.Add(new Employee { id = 1, Name = "Bhavna", Blood_Group = "B+", Mobile = 54678903 });
            //emp.Add(new Employee { id = 1, Name = "Bhargavi", Blood_Group = "B+", Mobile = 54678903 });
            //emp.Add(new Employee { id = 1, Name = "Bhaghat", Blood_Group = "B+", Mobile = 54678903 });
            //emp.Add(new Employee { id = 1, Name = "Buddi", Blood_Group = "B+", Mobile = 54678903 });
            //emp.Add(new Employee { id = 1, Name = "Bandi", Blood_Group = "B+", Mobile = 54678903 });


            //foreach(Employee str1 in emp)
            //{
            //    Console.WriteLine($"Id={str1.id},Name={str1.Name},Phone={str1.Mobile},Blood_group={str1.Blood_Group}");
            //}
            
            HashSet<Employee> emp1 = new HashSet<Employee>();
            emp1.Add(new Employee { id = 1, Name = "Bhavna", Blood_Group = "B+", Mobile = 54678903 });
            emp1.Add(new Employee { id = 1, Name = "Bhavna", Blood_Group = "B+", Mobile = 54678903 });
            emp1.Add(new Employee { id = 1, Name = "Bhavna", Blood_Group = "B+", Mobile = 54678903 });
            emp1.Add(new Employee { id = 1, Name = "Bhavna", Blood_Group = "B+", Mobile = 54678903 });
            emp1.Add(new Employee { id = 1, Name = "Bhavna", Blood_Group = "B+", Mobile = 54678903 });

            Console.WriteLine("-------------------------");
            Console.WriteLine("hashset is not working on class model");
            Console.WriteLine("-------------------------");

            foreach (Employee str2 in emp1)
            {
                Console.WriteLine($"Id={str2.id},Name={str2.Name},Phone={str2.Mobile},Blood_group={str2.Blood_Group}");
            }

            HashSet<int> num = new HashSet<int>();
            num.Add(10);
            num.Add(20);
            num.Add(30);
            num.Add(40);
            num.Add(10);
            Console.WriteLine("-------------------------");
            Console.WriteLine("hashset");
            Console.WriteLine("-------------------------");
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }

            SortedList sl = new SortedList();
            sl.Add(1,10);
            sl.Add(5,30);
            sl.Add(3,40);
            sl.Add(4,60);
            sl.Add(2,80);

            Console.WriteLine("-------------------------");
            Console.WriteLine("sorted list");
            Console.WriteLine("-------------------------");

            ICollection i = sl.Keys;

            foreach (int n in i)
            {
                Console.WriteLine(n+": "+ sl[n]);
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("madhavi");
            stack.Push("mrudhula");
            stack.Push("jungkook");
            stack.Push("taehyung");
            stack.Push("jimin");

            Console.WriteLine("-------------------------");
            Console.WriteLine("stack list follows LIFO");
            Console.WriteLine("-------------------------");


            foreach (string n in stack)
            {
                Console.WriteLine(n);
            }

            Queue<string> que = new Queue<string>();
            que.Enqueue("madhavi");
            que.Enqueue("mrudhula");
            que.Enqueue("jungkook");
            que.Enqueue("taehyung");
            que.Enqueue("jimin");

            Console.WriteLine("-------------------------");
            Console.WriteLine("queue list follows FIFO");
            Console.WriteLine("-------------------------");

            foreach (string n in stack)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-------------------------");

        }
    }
}
