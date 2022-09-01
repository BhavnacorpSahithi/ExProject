using Store.Interfaces;
using Store.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Store.Implementation
{
   public class CategoryImp : ICategory
    {
        Category cat = new Category();
        SqlConnection con = new SqlConnection("server=localhost;database=Bhavnacorp;Integrated Security=true");
        public void search()
        {
            try
            {
                Console.WriteLine("enter id: "); cat.Id = int.Parse(Console.ReadLine());

                SqlDataAdapter da = new SqlDataAdapter("select * from persons", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "persons");
                int x = ds.Tables[0].Rows.Count;

                for (int i = 0; i < x; i++)
                {
                    if (cat.Id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                    {
                        Console.WriteLine("Id: " + ds.Tables[0].Rows[i][0].ToString()); ;
                        Console.WriteLine("Name: " + ds.Tables[0].Rows[i][1].ToString());
                     
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("erroe message is: " + ex);
            }
            finally
            {
                Console.WriteLine("Console crud with sql");
            }
        }
        public void insert(Category cat)
        {
            try { 
            Console.WriteLine("enter id: "); cat.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cat_id: "); cat.Name = Console.ReadLine();

            SqlCommand com = new SqlCommand("insert into Category values(" + cat.Id + ",'" + cat.Name + "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Record inserted :)");
        }
            catch(Exception ex)
            {
                Console.WriteLine("erroe message is: " + ex);
            }
            finally
            {
                Console.WriteLine("Console crud with sql");
            }
        }
        public void update()
        {
            try
            {
                Console.WriteLine("enter id: "); cat.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter cat_id: "); cat.Name = Console.ReadLine();
                con.Open();
                SqlCommand cmd = new SqlCommand("update Category set cat_name= '" + cat.Name + "' where Id =" + cat.Id + " ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Record updated :)");
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
        public int delete(int id)
        {
            try
            {
                Console.WriteLine("enter id: "); id = int.Parse(Console.ReadLine());

                SqlCommand cmd1 = new SqlCommand("delete from Category where Id =" + id + "", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Record deleted :)");
            }
            catch (Exception ex)
            {
                Console.WriteLine("erroe message is: " + ex);
            }
            finally
            {
                Console.WriteLine("Console crud with sql");
            }
            return id;
        }
    }
}
