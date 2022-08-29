using Library;
using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;

namespace Asessment4CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    op.AddDoctors();
                    goto case 3;
                case 2:
                    op.AddPatients();
                    goto case 4;
                case 3:
                    op.DisplayDoctors();
                    break;
                case 4:
                    op.DisplayPatients();
                    break;
                case 5:
                    op.Addbill();
                    goto case 6;
                case 6:
                    op.Displaybill();
                    break;
            }
        }
    }
    public class Operations : IDoctors, IPatients,Ibill
    {
        List<Doctors> doctor = new List<Doctors>();
        List<Patients> patient = new List<Patients>();
        List<bill> bills = new List<bill>();

        public void Addbill()
        {
            bills.Add(new bill { Id = 101,doctor_charge=1000,room_charge=2500,no_of_days=5,lab_charge=1000,bill_no=1234,totalbill=5000 });
            bills.Add(new bill { Id = 102, doctor_charge = 1000, room_charge = 2000, no_of_days = 5, lab_charge = 1000, bill_no = 1744, totalbill = 5000 });
            bills.Add(new bill { Id = 103, doctor_charge = 1000, room_charge = 2000, no_of_days = 5, lab_charge = 1000, bill_no = 1644, totalbill = 4000 });
            bills.Add(new bill { Id = 104, doctor_charge = 1000, room_charge = 2000, no_of_days = 5, lab_charge = 1000, bill_no = 1854, totalbill = 4000 });
            bills.Add(new bill { Id = 105, doctor_charge = 1000, room_charge = 3000, no_of_days = 5, lab_charge = 1000, bill_no = 1644, totalbill = 6000 });

        }

        public void AddDoctors()
        {
            Console.WriteLine("adding the record");
            doctor.Add(new Doctors { Id=101,Name="sohit",Mobile=123456,Gender="Male",Age=45,Salary=20000,Specialist="Gynacoogist"  });
            doctor.Add(new Doctors { Id = 102, Name = "sohit", Mobile = 123456, Gender = "Male", Age = 45, Salary = 20000, Specialist = "Gynacoogist" });
            doctor.Add(new Doctors { Id = 103, Name = "sohit", Mobile = 123456, Gender = "Male", Age = 45, Salary = 20000, Specialist = "Gynacoogist" });
            doctor.Add(new Doctors { Id = 104, Name = "sohit", Mobile = 123456, Gender = "Male", Age = 45, Salary = 20000, Specialist = "Gynacoogist" });
            doctor.Add(new Doctors { Id = 105, Name = "sohit", Mobile = 123456, Gender = "Male", Age = 45, Salary = 20000, Specialist = "Gynacoogist" });
        }

        public void AddPatients()
        {
            Console.WriteLine("adding the record");
            patient.Add(new Patients { Id = 101, Name = "prasad", Mobile = 123456, Gender = "Male", Age = 45,RegisterFee=100,Problem="fever",DOJ=1/1/22});
            patient.Add(new Patients { Id = 102, Name = "sohit", Mobile = 123456, Gender = "Male", Age = 45, RegisterFee = 100, Problem = "fever", DOJ = 1 / 1 / 22 });
            patient.Add(new Patients { Id = 103, Name = "sohit", Mobile = 123456, Gender = "Male", Age = 45, RegisterFee = 100, Problem = "fever", DOJ = 1 / 1 / 22 });
            patient.Add(new Patients { Id = 104, Name = "sohit", Mobile = 123456, Gender = "Male", Age = 45, RegisterFee = 100, Problem = "fever", DOJ = 1 / 1 / 22 });
            patient.Add(new Patients { Id = 105, Name = "sohit", Mobile = 123456, Gender = "Male", Age = 45, RegisterFee = 100, Problem = "fever", DOJ = 1 / 1 / 22 });
            patient.Add(new Patients { Id = 106, Name = "sohit", Mobile = 123456, Gender = "Male", Age = 45, RegisterFee = 100, Problem = "fever", DOJ = 1 / 1 / 22 });
        }

        public void Displaybill()
        {
            foreach (bill billing in bills)
            {
                Console.WriteLine(billing.Id + "/" + billing.Mobile+"/"+ billing.doctor_charge + "/" + billing.Gender + "/" + billing.Age + "/" + billing.lab_charge + "/" + billing.lab_charge+"/"+ billing.no_of_days+"/"+ billing.totalbill);
            }
        }

        public void DisplayDoctors()
        {
            Console.WriteLine("displaying record the record");
            foreach (Doctors doc in doctor)
            {
                Console.WriteLine(doc.Id + "/" + doc.Name + "/" + doc.Mobile + "/" + doc.Gender + "/" + doc.Age + "/" + doc.Salary + "/" + doc.Specialist);
            }
        }

        public void DisplayPatients()
        {
            foreach (Patients patients in patient)
            {
                Console.WriteLine(patients.Id + "/" + patients.Name + "/" + patients.Mobile + "/" + patients.Gender + "/" + patients.Age + "/" + patients.DOJ + "/" + patients.Problem+"/"+patients.RegisterFee);
            }
        }
    }
}
