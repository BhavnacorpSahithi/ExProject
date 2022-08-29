using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment4CS.Sample
{
    public partial class Emp
    {
        public void AddEmp()
        {
            Console.WriteLine("i am adding an employee");
            //List<Employee> emp = new List<Employee>()
            //{
            emp.Add(new Employee { employeeId = 6, employeeName = "Taehyung", employeeGender = "Male", employeeMobile = 987564, employeeSalary = 50000 });
           // };
            
        }
        public void ShowEmp()
        {
            Console.WriteLine("Displaying an employee");
           foreach(Employee employee in emp)
            {
                Console.WriteLine(employee.employeeId+"/"+ employee.employeeName + "/" + employee.employeeGender + "/" + employee.employeeMobile + "/" + employee.employeeSalary );
            }
        }

        public void RemEmp()
        {
            Console.WriteLine("removing an employee");
            Console.WriteLine("select an index where to start");
            int indvalue = int.Parse(Console.ReadLine());
            Console.WriteLine("removing count an employee from list");
            int value = int.Parse(Console.ReadLine());
            emp.RemoveRange(indvalue, value);
        }
        public virtual void Showmsg()
        {
            Console.WriteLine("Displying the records after all functions");
        }
       
    }
}
