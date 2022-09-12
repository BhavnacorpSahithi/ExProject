using Management.Interfaces;
using Management.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Management.Implementation
{
   public class StaffImp :IStaff
    {
        Staff cat = new Staff();
        SqlConnection con = new SqlConnection("server=localhost;database=Assessment;Integrated Security=true");
        public void staff_insert()
        {
            try {
                 Console.WriteLine("enter username: "); cat.username = Console.ReadLine();
                Console.WriteLine("enter password: "); cat.password = Console.ReadLine();


                SqlDataAdapter da = new SqlDataAdapter("select * from Car_Staff", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Car_Staff");
                int x = ds.Tables[0].Rows.Count;

                for (int i = 0; i < x;)
                {
                    if (cat.username.ToString() == ds.Tables[0].Rows[i][4].ToString() && cat.password.ToString() == ds.Tables[0].Rows[i][5].ToString())
                    {
                       // Console.WriteLine("enter id: "); cat.Staff_id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter staff_name: "); cat.Staff_Name = Console.ReadLine();
                        Console.WriteLine("enter Dept: "); cat.Dept = Console.ReadLine();
                        Console.WriteLine("enter Salary: "); cat.Salary = long.Parse(Console.ReadLine());
                        Console.WriteLine("enter username: "); cat.username = Console.ReadLine();
                        Console.WriteLine("enter password: "); cat.password = Console.ReadLine();
                        Console.WriteLine("enter noofdays: "); cat.No_of_days = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter Sid: "); cat.Sid = int.Parse(Console.ReadLine());

                        SqlCommand com = new SqlCommand("insert into Car_Staff values('" + cat.Staff_Name + "','" + cat.Dept + "'," + cat.Salary + ",'" + cat.username + "','" + cat.password + "',"+ cat.No_of_days + ",'"+cat.role+"'," + cat.Sid + ")", con);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        Console.WriteLine("Record inserted :)");

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("error message is: " + ex);
            }
            finally
            {
                Console.WriteLine("Console crud with sql");
            }
        }
        public void staff_update()
        {
            try
            {
                Console.WriteLine("enter username: "); cat.username = Console.ReadLine();
                Console.WriteLine("enter password: "); cat.password = Console.ReadLine();


                SqlDataAdapter da = new SqlDataAdapter("select * from Car_Staff", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Car_Staff");
                int x = ds.Tables[0].Rows.Count;

                for (int i = 0; i < x; i++)
                {
                    if (cat.username.ToString() == ds.Tables[0].Rows[i][4].ToString() && cat.password.ToString() == ds.Tables[0].Rows[i][5].ToString())
                    {
                        Console.WriteLine("enter staff_name: "); cat.Staff_Name = Console.ReadLine();
                        Console.WriteLine("enter Dept: "); cat.Dept = Console.ReadLine();
                        Console.WriteLine("enter Salary: "); cat.Salary = long.Parse(Console.ReadLine());
                        Console.WriteLine("enter username: "); cat.username = Console.ReadLine();
                        Console.WriteLine("enter password: "); cat.password = Console.ReadLine();
                        Console.WriteLine("enter noofdays: "); cat.No_of_days = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter Sid: "); cat.Sid = int.Parse(Console.ReadLine());

                        SqlCommand com = new SqlCommand("update Car_Products set Staff_name'" + cat.Staff_Name + "',Dept'" + cat.Dept + "',Salary'" + cat.Salary + "',username'" + cat.username + "',password='" + cat.password + "',No_of_days=" + cat.No_of_days + ",Sid='"+cat.Sid+"',role='"+cat.role+"'where Staff_id=" + cat.Staff_id + "", con);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        Console.WriteLine("Record inserted :)");

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("error: ", ex);
            }
        }
        public void staff_delete()
        {
            try
            {
                 Console.WriteLine("enter id: "); int id = int.Parse(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("delete from Car_Staff where Staff_id =" + id + "", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Record deleted :)");
                SqlConnection con1 = new SqlConnection("server=localhost;database=Bhavnacorp;Integrated Security=true");
                Console.WriteLine("Enter  Paragraph");
                string para = "Record deleted :)";
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into sampledata values('" + para + "')", con1);
                StreamWriter sw = new StreamWriter("D:/Training/SqlDay6/sample.txt");
                Console.WriteLine($"value={para}");
                sw.Write("Hi  welcome " + (Environment.NewLine) + para);
                sw.Close();
                cmd.ExecuteNonQuery();
                con.Close();
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
        public void staff_salary()
        {
            try
            {
                Console.WriteLine("enter id: "); int id = int.Parse(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("select *,(Salary * No_of_hours) as totalSalary from Car_Staff where Staff_id=" + id + "", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Console.WriteLine($"salary calculated of employee id ={id} :)");
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

    }
}
