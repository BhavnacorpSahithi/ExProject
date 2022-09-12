using Store.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace SqlAdoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            Category cat = new Category();
            SqlConnection con = new SqlConnection("server=localhost;database=Bhavnacorp;Integrated Security=true");
            Console.WriteLine("to enter y or n");
            string repeat = Console.ReadLine();

            while (repeat == "y")
            {

                Console.WriteLine("enter ur choice");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter  Paragraph");
                        string para = Console.ReadLine();
                        List<string> paragraph = new List<string>();
                        paragraph.Add(para);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into sampledata values('" + para + "')", con);
                        StreamWriter sw = new StreamWriter("D:/Training/SqlDay6/sample.txt");
                        foreach(string par in paragraph)
                        {
                            Console.WriteLine($"value={par}");
                            sw.Write("Hi  welcome " + (Environment.NewLine) + para);
                        }
                        sw.Close();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                }
                Console.WriteLine("do u want to continue y/n");
                repeat = Console.ReadLine();
            }
         
        }
      
    }
}































//try
//{
//    Console.WriteLine("enter cat_id: "); cat.Id = int.Parse(Console.ReadLine());
//    Console.WriteLine("enter cat_name: "); cat.Name = Console.ReadLine();

//    SqlCommand com = new SqlCommand("insert into Category values(" + cat.Id + ",'" + cat.Name + "')", con);
//    con.Open();
//    com.ExecuteNonQuery();
//       pr.inserttext(cat);
//   // pr.inserttext(cat.Id, cat.Name);
//    con.Close();
//    Console.WriteLine("Record inserted :)");
//}
//catch (Exception ex)
//{
//    Console.WriteLine("error message is: " + ex);
//}
//finally
//{
//    Console.WriteLine("Console crud with sql");
//}


//public void inserttext(Category cat)
//{
//      var text = Encoding.ASCII.GetBytes("the records are inserted \n {0}:{1}",Convert.cat);
//    FileStream fs = new FileStream("D:/Training/SqlDay6/dummydata.txt",FileMode.Create&FileMode.Open);
//    fs.Write(Encoding.Default.GetBytes(text.ToString()));
//    Console.WriteLine("text inserted");
//    fs.Close();

//    //string data;
//    //  byte[] bdata = Encoding.Default.GetBytes("Hello File Handling!");
//    //using (StreamReader sr = new StreamReader(fs))
//    //{
//    //    data = sr.ReadToEnd();
//    //}
//    //Console.WriteLine(data);
//    //Console.ReadLine();
//}
