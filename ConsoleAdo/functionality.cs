using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleAdo
{
   public class functionality : IFunctions
    {
        People ppl = new People();
        SqlConnection con = new SqlConnection("server=localhost;database=basic;Integrated Security=true");
        public void search()
        {
            try
            {
                Console.WriteLine("enter id: "); ppl.id = int.Parse(Console.ReadLine());

                SqlDataAdapter da = new SqlDataAdapter("select * from persons", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "persons");
                int x = ds.Tables[0].Rows.Count;

                for (int i = 0; i < x; i++)
                {
                    if (ppl.id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                    {
                        Console.WriteLine("id: " + ds.Tables[0].Rows[i][0].ToString()); ;
                        Console.WriteLine("firstname: " + ds.Tables[0].Rows[i][1].ToString());
                        Console.WriteLine("lastname: " + ds.Tables[0].Rows[i][2].ToString()); ;
                        Console.WriteLine("age: " + ds.Tables[0].Rows[i][3].ToString()); ;
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
        public void insert()
        {
            try { 
            Console.WriteLine("enter id: "); ppl.id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter firstname: "); ppl.firstName = Console.ReadLine();
            Console.WriteLine("enter lastname: "); ppl.lastName = Console.ReadLine();
            Console.WriteLine("enter age: "); ppl.Age = int.Parse(Console.ReadLine());

            SqlCommand com = new SqlCommand("insert into persons values(" + ppl.id + ",'" + ppl.firstName + "','" + ppl.lastName + "'," + ppl.Age + ")", con);
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
            try { 
            Console.WriteLine("enter id: ");
            ppl.id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter firstname: "); ppl.firstName = Console.ReadLine();
            Console.WriteLine("enter lastname: "); ppl.lastName = Console.ReadLine();
            Console.WriteLine("enter age: "); ppl.Age = int.Parse(Console.ReadLine());
            con.Open();
            SqlCommand cmd = new SqlCommand("update persons set firstName= '" + ppl.firstName + "', lastName= '" + ppl.lastName + "' , Age= " + ppl.Age + " where PersonID =" + ppl.id + " ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Record updated :)");
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
        public void delete()
        {
            try { 
            Console.WriteLine("enter id: "); ppl.id = int.Parse(Console.ReadLine());

            SqlCommand cmd1 = new SqlCommand("delete from persons where PersonID =" + ppl.id + "", con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Record deleted :)");
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
    }
}
