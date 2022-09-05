using Franchise.Interfaces;
using Franchise.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Franchise.Def
{
    public class AdminImp : IAdmin
    {
        Franchise1 fr = new Franchise1();
        Admin lgn = new Admin();
        SqlConnection con = new SqlConnection("server=localhost;database=vbforms;Integrated Security=true");
        public void delete()
        {
            try
            {
                Console.WriteLine("enter id: "); lgn.admin_id = int.Parse(Console.ReadLine());

                SqlCommand cmd1 = new SqlCommand("delete from Admin where Id =" + lgn.admin_id + "", con);
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

        public void gettotalsales()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select sum(sales) as total_sales, count(Date) countof_sameday from franchise1 group by Date", con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    Console.WriteLine(da.GetValue(0) + "/" + da.GetValue(1) + "\n");
                }
                Console.WriteLine("found success"); con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error in admin func" + ex);
            }
        }

        public void insert()
        {
            try
            {
                Console.WriteLine("enter email: "); lgn.username = Console.ReadLine();
                Console.WriteLine("enter password: "); lgn.password = Console.ReadLine();
                Console.WriteLine("enter total sales: "); lgn.total_sales = int.Parse(Console.ReadLine());
                Console.WriteLine("enter f_id: "); lgn.f1_id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter role: "); lgn.role = Console.ReadLine();
                Console.WriteLine("enter f_name: "); lgn.franchise_name = Console.ReadLine();
                Console.WriteLine("enter f_branch: "); lgn.franchise_branch = Console.ReadLine();
                con.Close();
                SqlCommand com = new SqlCommand("insert into Admin values('" + lgn.username + "','" + lgn.password + "','" + lgn.total_sales + "','" + lgn.f1_id + "','"+lgn.role+"','"+lgn.franchise_name+"','"+lgn.franchise_branch+"')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Record inserted :)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro message is: " + ex);
            }
            finally
            {
                Console.WriteLine("Console crud with sql");
            }
        }

        public void loginadmin()
        {
                try
                {
                    Console.WriteLine("enter email: "); lgn.username = Console.ReadLine();
                    Console.WriteLine("enter password: "); lgn.password = Console.ReadLine();
                    SqlCommand cmd = new SqlCommand("select * from Admin where username='" + lgn.username + "'and password='" + lgn.password + "'", con);
                    con.Open();
                    SqlDataReader da = cmd.ExecuteReader();
                Console.WriteLine("admin login success");
                    con.Close();
                }
            catch (Exception ex)
                {
                    Console.WriteLine("error in admin func" + ex);
                }
            }

        public void salarydistribution()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select sum(12*Salary) as Total_salary,count(F1_Id) from franchise1 where role=2 group by F1_Id", con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    Console.WriteLine(da.GetValue(0) + "/" + da.GetValue(1) + "/" + da.GetValue(2) + "/" + da.GetValue(3) + "/" + da.GetValue(4) + "/" + da.GetValue(5) + "/" + da.GetValue(6) + "/" + da.GetValue(7)+"\n");
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
    //2009-06-23 19:30:20.000
}
