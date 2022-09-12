using Store;
using Management.Interfaces;
using Management.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Management.Implementation
{
    public class ProductImp : IProducts
    {
                Products prod = new Products();
                Staff staff = new Staff();
                SqlConnection con = new SqlConnection("server=localhost;database=Assessment;Integrated Security=true");
        public void prod_search()
        {
            try
            {
                Console.WriteLine("enter : "); prod.Prod_Name = Console.ReadLine();

                SqlDataAdapter da = new SqlDataAdapter("select * from Car_Products", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Car_Products");
                int x = ds.Tables[0].Rows.Count;

                for (int i = 0; i < x; i++)
                {
                    if (prod.Prod_Name.ToString() == ds.Tables[0].Rows[i][1].ToString())
                    {
                        Console.WriteLine("Id: " + ds.Tables[0].Rows[i][0].ToString()); ;
                        Console.WriteLine("Name: " + ds.Tables[0].Rows[i][1].ToString());
                        Console.WriteLine("Quantity: " + ds.Tables[0].Rows[i][2].ToString());
                        Console.WriteLine("Price: " + ds.Tables[0].Rows[i][3].ToString()); 
                    }
                }
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
        public void prod_insert()
        {
            try
            {
                Console.WriteLine("enter username: "); staff.username = Console.ReadLine();
                Console.WriteLine("enter password: "); staff.password = Console.ReadLine();


                SqlDataAdapter da = new SqlDataAdapter("select * from Car_Staff", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Car_Staff");
                int x = ds.Tables[0].Rows.Count;

                for (int i = 0; i < x; i++)
                {
                    if (staff.username.ToString() == ds.Tables[0].Rows[i][4].ToString() && staff.password.ToString() == ds.Tables[0].Rows[i][5].ToString())
                    {
                        Console.WriteLine("enter prod_name: "); prod.Prod_Name = Console.ReadLine();
                        Console.WriteLine("enter quantity: "); prod.Quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter price: "); prod.Price = int.Parse(Console.ReadLine());

                        SqlCommand com = new SqlCommand("insert into Car_Products values('" + prod.Prod_Name + "','" + prod.Quantity + "'," + prod.Price + ")", con);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        Console.WriteLine("Record inserted :)");

                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("error: ", ex);
            }
        }
       public void prod_update()
        {
           try
            {
                    Console.WriteLine("enter username: "); staff.username = Console.ReadLine();
                    Console.WriteLine("enter password: "); staff.password = Console.ReadLine();


                    SqlDataAdapter da = new SqlDataAdapter("select * from Car_Staff", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Car_Staff");
                    int x = ds.Tables[0].Rows.Count;

                    for (int i = 0; i<x; i++)
                    {
                        if (staff.username.ToString() == ds.Tables[0].Rows[i][4].ToString() && staff.password.ToString() == ds.Tables[0].Rows[i][5].ToString())
                        {
                        Console.WriteLine("enter prod_id: "); prod.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter prod_name: "); prod.Prod_Name = Console.ReadLine();
                            Console.WriteLine("enter quantity: "); prod.Quantity = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter price: "); prod.Price = int.Parse(Console.ReadLine());

                           SqlCommand com = new SqlCommand("update Car_Products set PROD_name'" + prod.Prod_Name + "',PROD_stock='" + prod.Quantity + "',Prod_price=" + prod.Price + "where PROD_ID="+prod.Id+"", con);
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
        public void prod_delete()
        {
            try
            {
                Console.WriteLine("enter password: "); int id = int.Parse(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("delete from Car_Products where PROD_ID =" + id + "", con);
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

        public void get_Stafftimings()
        {
            try
            {

                SqlCommand cmd2 = new SqlCommand("select p.Staff_id,p.Staff_name,p.Dept,p.role,c.Shift_name,c.Login,c.Logout from Car_Staff as p left join Car_shift as c on p.Sid = c.Shift_Id", con);
                con.Open();
                SqlDataReader sdr = cmd2.ExecuteReader();
                while (sdr.Read())
                {
                    Console.Write("Id: " + sdr.GetValue(0) + "/ staffName: " + sdr.GetValue(1) + "/ Dept: " + sdr.GetValue(2) + "/ role: " + sdr.GetValue(3) + "/ Shift_name: " + sdr.GetValue(4) + "/ Login: " + sdr.GetValue(4) + "/ Logout: " + sdr.GetValue(4) + "\n");
                }
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
    }
}
