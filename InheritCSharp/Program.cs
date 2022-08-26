using System;

namespace InheritCSharp
{
    class Program 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string res = Console.ReadLine();
            
            Game game = new Game();

            if (res == "Y")
            {
                switch (n)
                {
                    case 1:
                        game.CoachDetails();
                        goto case 2;
                    case 2:
                        game.ShowCoach();
                        break;
                    case 3:
                        game.PlayerDetails();
                        goto case 4;
                    case 4:
                        game.ShowPlayer();
                        goto case 2;
                }
            }
            else 
            {
                Console.WriteLine("you have exited the switch");
                Console.ReadLine();
            }

        }
    }
    public class Game:ICoach,IPlayer
    {
        Player[] pl = new Player[2];

        public void CoachDetails()
        {
            Coach[] ch = new Coach[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("enter the Coach id: ");
                ch[i].Id = int.Parse(Console.ReadLine());
                Console.Write("enter the Coach Name: "); 
                ch[i].Name = Console.ReadLine();
                Console.Write("enter the Coach Gender: "); 
                ch[i].Gender = Console.ReadLine();
                Console.Write("enter the Coach Mobile: "); 
                ch[i].Mobile = int.Parse(Console.ReadLine());
                Console.Write("enter the Coach Game: "); 
                ch[i].Game = Console.ReadLine();
                Console.Write("enter the Coach Rm: ");
                ch[i].Rm = Console.ReadLine();
                Console.Write("enter the Coach Salary: "); 
                ch[i].Salary = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PlayerDetails()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("enter the Player id: "); pl[i].Id = int.Parse(Console.ReadLine());
                Console.Write("enter the Player Name: "); pl[i].Name = Console.ReadLine();
                Console.Write("enter the Player Gender: "); pl[i].Gender = Console.ReadLine();
                Console.Write("enter the Player Height: "); pl[i].height = int.Parse(Console.ReadLine());
                Console.Write("enter the Player Weight: "); pl[i].weight = int.Parse(Console.ReadLine());
                Console.Write("enter the Player Weight: "); pl[i].fee = int.Parse(Console.ReadLine());
                Console.Write("enter the Player Timings: "); pl[i].Timings = Console.ReadLine();
            }
        }

        public void ShowCoach()
        {
            Coach[] ch = new Coach[2];
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("enter the Coach id: " + ch[i].Id);
                Console.Write("enter the Coach Name: " + ch[i].Name);
                Console.Write("enter the Coach Gender: " + ch[i].Gender);
                Console.Write("enter the Coach Gender: " + ch[i].Mobile);
                Console.Write("enter the Coach Game: " + ch[i].Game);
                Console.Write("enter the Coach Rm: " + ch[i].Rm);
                Console.Write("enter the Coach Salary: " + ch[i].Salary);
            }
        }

        public void ShowPlayer()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("enter the Player id: " + pl[i].Id);
                Console.Write("enter the Player Name: " + pl[i].Name);
                Console.Write("enter the Player Gender: " + pl[i].Gender);
                Console.Write("enter the Player Gender: " + pl[i].fee);
                Console.Write("enter the Player Mobile: " + pl[i].Mobile);
                Console.Write("enter the Player Height: " + pl[i].height);
                Console.Write("enter the Player Weight: " + pl[i].weight);
                Console.Write("enter the Player Timings: " + pl[i].Timings);
            }
        }
    } 
}
