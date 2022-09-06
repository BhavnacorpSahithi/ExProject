using ATMApp.Domain.Entities;
using ATMApp.Domain.Interfaces;
using ATMApp.UI;
using System;
using System.Collections.Generic;

namespace ATMApp
{
    public class Main : IUserLogin
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{Id=1, FullName = "Sahithi A", AccountNumber=123456,CardNumber =321321, CardPin=123123,AccountBalance=50000.00m,IsLocked=false},
                new UserAccount{Id=2, FullName = "Dhanu T", AccountNumber=456789,CardNumber =654654, CardPin=456456,AccountBalance=4000.00m,IsLocked=false},
                new UserAccount{Id=3, FullName = "Raki B", AccountNumber=123555,CardNumber =987987, CardPin=789789,AccountBalance=2000.00m,IsLocked=true},
                new UserAccount{Id=4, FullName = "Praveen S", AccountNumber=987654,CardNumber =456789, CardPin=789789,AccountBalance=3000.00m,IsLocked=false},
                new UserAccount{Id=5, FullName = "Mohit S", AccountNumber=123456,CardNumber =654321, CardPin=789789,AccountBalance=1500.00m,IsLocked=true},
            };
        }

        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;
            while (isCorrectLogin == false)
            {
                UserAccount inputAccount = AppScreen.UserLoginForm();
                AppScreen.LoginProgress();
                foreach(UserAccount account in userAccountList)
                {
                    selectedAccount = account;
                    if (inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
                    {
                        selectedAccount.TotalLogin++;

                        if (inputAccount.CardPin.Equals(selectedAccount.CardPin))
                        {
                            selectedAccount = account;

                            if(selectedAccount.IsLocked || selectedAccount.TotalLogin > 3)
                            {
                                AppScreen.PrintLockScreen();
                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                isCorrectLogin = true;
                                break;
                            }
                        }
                    }
                    if (isCorrectLogin == false)
                    {
                        Utility.PrintMessage("\nInvalid card number or PIN.", false);
                        selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
                        if (selectedAccount.IsLocked)
                        {
                            AppScreen.PrintLockScreen();
                        }
                    }
                    Console.Clear();
                }
            }
            
        }

        public void Welcome()
        {
            Console.WriteLine($"Welcome back, {selectedAccount.FullName}");
            Utility.PressEnterToContinue();
        }

        
    }
}
