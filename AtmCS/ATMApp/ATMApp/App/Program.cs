using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                AppScreen.Welcome();
                Main atmApp = new Main();
                atmApp.InitializeData();
                atmApp.CheckUserCardNumAndPassword();
                atmApp.Welcome();
            }
        }
    }
}
