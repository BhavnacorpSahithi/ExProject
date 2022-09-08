using System;

namespace BasicCS_Ytb
{
    class Program
    {
        static void Main(string[] args)
        {
            startpoint: Console.WriteLine("Welcome to our proj \n=================");
            Console.WriteLine("1-help\n 2-calculate\n 3-setting\n 4-exit \n=================");
            string start = Console.ReadLine();
            if(start == "1")
            {
                Console.Clear();
                Console.WriteLine("Any help needed?====================\n *:back");
                string go = Console.ReadLine();
                if(go == "*")
                {
                    Console.Clear();
                    goto startpoint;
                }
            }
            else if(start == "2")
            {
                Console.Clear();
               calculate: Console.WriteLine("Calculate====================\n1-calculate \\ *:back");
                string go = Console.ReadLine();
                if(go == "1")
                {
                   // Console.WriteLine("Calculate====================\\ *:back");
                    Console.Clear();
                   double num1, num2,res;char operators;
                  Console.WriteLine("num1: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("operator: ");
                    operators = char.Parse(Console.ReadLine());
                    Console.WriteLine("num2: ");
                    num2 = double.Parse(Console.ReadLine());

                    if(operators == '+')
                    {
                        res = num1 + num2;
                        Console.WriteLine("{0}+{1}={2}",num1,num2,res);
                        goto calculate;
                    }
                    else if (operators == '*')
                    {
                        res = num1 * num2;
                        Console.WriteLine("{0}*{1}={2}", num1, num2, res);
                        goto calculate;
                    }
                    else if (operators == '/')
                    {
                        res = num1 / num2;
                        Console.WriteLine("{0}/{1}={2}", num1, num2, res);
                        if(num2 == 0)
                        {
                            Console.WriteLine("math error");
                        }
                        goto calculate;
                    }

                }
                else if (go == "*")
                {
                    Console.Clear();
                    goto startpoint;
                }

            }
            else if (start == "3")
            {
                Console.Clear();
            colorsetting: Console.WriteLine("settings\\interface\\1-colour\n **:colorsetting \\*:back");
                string interfacechoice = Console.ReadLine();
                if(interfacechoice == "1")
                {
                    Console.Clear();
                    n: Console.WriteLine("settings\\interface\n1-yellow\n2-red\n3-blue\n *:back\\-:repeat colorsetting");
                      string color = Console.ReadLine();
                      if(color == "1")
                    {
                        Console.WriteLine("clicked yellow color for background");
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        goto n;
                    }
                    else if (color == "2")
                    {
                        Console.WriteLine("clicked red color for background");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        goto n;
                    }
                    else if (color == "3")
                    {
                        Console.WriteLine("clicked blue color for background");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        goto n;
                    }
                    else if(color == "**")
                    {
                        Console.Clear();
                        goto colorsetting;
                    }
                    //else
                    //{
                    //    Console.WriteLine("invalid color");
                    //}

                }
                else if (interfacechoice == "*")
                {
                    Console.Clear();
                    goto startpoint;
                }

            }
            else if (start == "4")
            {
                Console.Clear();
                Console.WriteLine("exit====================\n *:back");
                Environment.Exit(0);
                //string go = Console.ReadLine();
                //if (go == "*")
                //{
                //    Console.Clear();
                //    goto startpoint;
                //}
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid options");
            }
            Console.ReadLine();

        }
    }
}
