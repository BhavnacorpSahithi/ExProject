using Assessment4CS.Sample;
using System;
using System.Collections.Generic;

namespace Assessment4CS
{
    class Program :Emp
    {
        static void Main(string[] args)
        {
            Emp empl = new Emp();
            empl.AddEmp();
            empl.ShowEmp();
            empl.RemEmp();
            empl.Showmsg();
            empl.ShowEmp();
        }
        public override void Showmsg()
        {
            base.Showmsg();
        }
    }
    
}
