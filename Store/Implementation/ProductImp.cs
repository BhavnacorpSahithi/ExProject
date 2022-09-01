using Store;
using Store.Interfaces;
using Store.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Store.Implementation
{
   public class ProductImp : IProducts
    {
        Products ppl = new Products();
        SqlConnection con = new SqlConnection("server=localhost;database=Bhavnacorp;Integrated Security=true");
        public void search()
        {
            try
            {
                Console.WriteLine("enter id: "); ppl.Id = int.Parse(Console.ReadLine());

                SqlDataAdapter da = new SqlDataAdapter("select * from ProductDetails", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "ProductDetails");
                int x = ds.Tables[0].Rows.Count;

                for (int i = 0; i < x; i++)
                {
                    if (ppl.Id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                    {
                        Console.WriteLine("Id: " + ds.Tables[0].Rows[i][0].ToString()); ;
                        Console.WriteLine("Name: " + ds.Tables[0].Rows[i][1].ToString());
                        Console.WriteLine("Price: " + ds.Tables[0].Rows[i][2].ToString()); ;
                        Console.WriteLine("Quantity: " + ds.Tables[0].Rows[i][3].ToString());
                        Console.WriteLine("cat_id: " + ds.Tables[0].Rows[i][4].ToString());
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
        public void insert(Products ppl)
        {
            try
            {
                Console.WriteLine("enter id: "); ppl.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Name: "); ppl.Name = Console.ReadLine();
                Console.WriteLine("enter quantity: "); ppl.Quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("enter price: "); ppl.Price = int.Parse(Console.ReadLine());
                Console.WriteLine("enter cat_id: "); ppl.cat_id = int.Parse(Console.ReadLine());

                SqlCommand com = new SqlCommand("insert into ProductDetails values(" + ppl.Id + ",'" + ppl.Name + "','" + ppl.Quantity + "'," + ppl.Price + ","+ppl.cat_id+")", con);
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
        public void update()
        {
            try
            {
                Console.WriteLine("enter id: "); ppl.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Name: "); ppl.Name = Console.ReadLine();
                Console.WriteLine("enter Quantity: "); ppl.Quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("enter price: "); ppl.Price = int.Parse(Console.ReadLine());
                Console.WriteLine("enter cat_id: "); ppl.cat_id = int.Parse(Console.ReadLine());
                con.Open();
                SqlCommand cmd = new SqlCommand("update ProductDetails set prodname= '" + ppl.Name + "', prodqty= '" + ppl.Quantity + "' , price= " + ppl.Price + ",cat_id="+ppl.cat_id+" where pid =" + ppl.Id + " ", con);
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

                SqlCommand cmd1 = new SqlCommand("delete from ProductDetails where pid =" + id + "", con);
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

        public void getproduct()
        {
            try
            {

                SqlCommand cmd2 = new SqlCommand("select  p.pid,p.prodname,p.price,p.prodqty,c.cat_name from ProductDetails as p left join Category as c on p.pid = c.Id", con);
                con.Open();
                SqlDataReader sdr = cmd2.ExecuteReader();
                while(sdr.Read())
                {
                   Console.Write("Id: " + sdr.GetValue(0) + "/ ProdName: "+ sdr.GetValue(1) + "/ Prodprice: " + sdr.GetValue(2) + "/ Prodqty: " + sdr.GetValue(3) + "/ cat_name: " + sdr.GetValue(4)+"\n");    
                }
                con.Close();
                
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
    }
}
