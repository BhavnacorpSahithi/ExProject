using Franchise.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Franchise.Def
{
    public class FranchiseImp : IFranchise1
    {
        Franchise1 lgn = new Franchise1();
        SqlConnection con = new SqlConnection("server=localhost;database=vbforms;Integrated Security=true");
        public void delete()
        {
            try
            {
                Console.WriteLine("enter id: "); lgn.f1_id = int.Parse(Console.ReadLine());

                SqlCommand cmd1 = new SqlCommand("delete from franchise1 where Id =" + lgn.f1_id + "", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Record deleted :)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error message is: " + ex);
            }
            finally
            {
                Console.WriteLine("Console crud with sql");
            }
        }

        public void insert()
        {
            try
            {
                Console.WriteLine("enter role: "); lgn.role = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name: "); lgn.Name = Console.ReadLine();
                Console.WriteLine("enter salary: "); lgn.Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("enter mobile: "); lgn.Mobile = int.Parse(Console.ReadLine());
                Console.WriteLine("enter sales: "); lgn.Sales = int.Parse(Console.ReadLine());
                Console.WriteLine("enter salary: ");string f_date = lgn.DOorder = DateTime.Now.ToString(Console.ReadLine());
                Console.WriteLine("enter email: "); lgn.username = Console.ReadLine();
                Console.WriteLine("enter password: "); lgn.password = Console.ReadLine();

                SqlCommand com = new SqlCommand("insert into franchise1 values('" + lgn.role + "','" + lgn.Name + "','" + lgn.Salary + "','" + lgn.Mobile + "','" + lgn.Sales + "','" + lgn.DOorder + "','" + lgn.username + "','" + lgn.password + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Record inserted :)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("erroe message is: " + ex);
            }
            finally
            {
                Console.WriteLine("Console crud with sql");
            }
        }

        public void loginuser()
        {
            try
            {
                Console.WriteLine("enter email: "); lgn.username = Console.ReadLine();
                Console.WriteLine("enter password: "); lgn.password = Console.ReadLine();
                SqlCommand cmd = new SqlCommand("select * from franchise1 where username='" + lgn.username + "'and password='" + lgn.password + "'", con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();
                Console.WriteLine("login successfull");
                con.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("error in login func" + ex);
            }
        }
        public void getpizzadetails()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT f.Name,f.Mobile,a.Pizza_name,a.Prizza_order_type,a.Ordered_date FROM franchise1 as f inner JOIN Pizza as a ON f.pizza_id = a.pizza_id", con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    Console.WriteLine(da.GetValue(0) + "/" + da.GetValue(1) + "/" + da.GetValue(2) + "/" + da.GetValue(3) + "/" + da.GetValue(4) + "\n");
                }
                Console.WriteLine("found success");
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error in admin func" + ex);
            }
        }
    }
}
