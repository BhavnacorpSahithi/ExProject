using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LibraryModel
{
    public class Crud : ICrud
    {
        login lgn = new login();
        Logger lgr = new Logger();
        SqlConnection con = new SqlConnection("server=localhost;database=vbforms;Integrated Security=true");
        public void delete()
        {
            try
            {
                Console.WriteLine("enter id: "); lgn.id = int.Parse(Console.ReadLine());

                SqlCommand cmd1 = new SqlCommand("delete from Login where Id =" + lgn.id + "", con);
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
                //Console.WriteLine("enter id: "); lgn.id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name: "); lgn.name = Console.ReadLine();
                Console.WriteLine("enter email: "); lgn.email = Console.ReadLine();
                Console.WriteLine("enter password: "); lgn.password = Console.ReadLine();
                Console.WriteLine("enter mobile: "); lgn.mobile = double.Parse(Console.ReadLine());

                SqlCommand com = new SqlCommand("insert into Login values('" + lgn.name + "','" + lgn.email +"','"+lgn.password +"','"+lgn.mobile+"')", con);
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
        public void loggerinsert()
        {
            try
            {
                //Console.WriteLine("enter name: "); lgn.name = Console.ReadLine();
                //Console.WriteLine("enter email: "); lgn.email = Console.ReadLine();
                //Console.WriteLine("enter password: "); lgn.password = Console.ReadLine();
                //Console.WriteLine("enter mobile: "); lgn.mobile = double.Parse(Console.ReadLine());

                SqlCommand com = new SqlCommand("insert into logger values('" + lgr.message + "','" + DateTime.Now + "','"+lgn.id+"')", con);
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
                Console.WriteLine("enter email: "); lgn.email = Console.ReadLine();
                Console.WriteLine("enter password: "); lgn.password = Console.ReadLine();

                SqlDataAdapter da = new SqlDataAdapter("select * from Login", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Login");
                int x = ds.Tables[0].Rows.Count;

                for (int i = 0; i < x; i++)
                {
                    if (lgn.email.ToString() == ds.Tables[0].Rows[i][2].ToString() && lgn.password == ds.Tables[0].Rows[i][3].ToString())
                    {
                        //Console.WriteLine("id: " + ds.Tables[0].Rows[i][0].ToString()); 
                        //Console.WriteLine("name: " + ds.Tables[0].Rows[i][1].ToString());
                        //Console.WriteLine("email: " + ds.Tables[0].Rows[i][2].ToString()); ;
                        //Console.WriteLine("password: " + ds.Tables[0].Rows[i][3].ToString());
                        //Console.WriteLine("mobile: " + ds.Tables[0].Rows[i][4].ToString());
                        Console.WriteLine("plz insert data");
                        insert();
                        loggerinsert();
                    }
                    else
                    {
                        Console.WriteLine("record not found ... ");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("error in login func" + ex);
            }
        }
    }
}
