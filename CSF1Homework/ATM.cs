using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.Title = "ATM";
            Console.WriteLine("----------ATM----------\n");

            bool userNameWrong = true;
            int accountNumber = 93574;

            bool userPinWrong = true;
            int accountPin = 0864;

            while (userNameWrong)
            {
                Console.WriteLine("Please enter you account number: ");
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber == accountNumber)
                {
                    userNameWrong = false;
                    while (userPinWrong)
                    {
                        Console.WriteLine("Please enter pin: ");
                        int userPin = int.Parse(Console.ReadLine());
                        if (userPin == accountPin)
                        {
                            userPinWrong = false;
                            bool repeat = true;
                            do
                            {
                                
                                Console.WriteLine("----------Menu----------");
                                Console.WriteLine("A) Deposit\nB) Withdraw\nC) Exit");

                                string userChoice = Console.ReadLine().ToUpper();

                                

                                switch (userChoice)
                                {
                                   
                                    case "A":
                                    case "DEPOSIT":
                                        Console.WriteLine("How Much would you like to deposit: ");
                                        decimal userDeposit = decimal.Parse(Console.ReadLine());
                                        Console.Clear();
                                        Console.WriteLine("{0:c} has been deposited into account {1}.\n\n", userDeposit, accountNumber);
                                        break;
                                    case "B":
                                    case "WITHDRAW":
                                        Console.WriteLine("How much would you like to withdraw: ");
                                        decimal userWithdraw = decimal.Parse(Console.ReadLine());
                                        Console.Clear();
                                        Console.WriteLine("{0:c} has been withdrawn from account {1}.\n\n", userWithdraw, accountNumber);
                                        break;
                                    case "C":
                                    case "EXIT":
                                        repeat = false;
                                        Console.Clear();
                                        Console.WriteLine("Thank you for using our ATM.");
                                        break;

                                }
                            } while (repeat);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Pin incorrect. Please try again.");
                        }
                    }//end userPinWrong while
                }//end userNumber == accountNumber if
                else
                {
                    Console.Clear();
                    Console.WriteLine("Account not found. Please try again.");

                }
            }//end userNameWrong while
            
        }//end main
    }//end class
}//end namespace
