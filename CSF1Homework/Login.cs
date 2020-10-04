 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            
            
            
            
                bool userNameWrong = true;
                int loopMax = 3;
                int loopTimes = 1;


            while (userNameWrong && loopTimes <= loopMax)
            {
                Console.WriteLine("Please enter your username: ");
                string userName = Console.ReadLine().ToLower();
                    if (userName == "purpleguy")
                    {
                        Console.WriteLine("Welcome, you have been granted access. ");
                        userNameWrong = false;
                    }//end if
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry, you have been denied access. Try Again. ");
                        loopTimes++;
                    if (loopTimes == 4)
                    {
                        Console.WriteLine("You have tried too many times. You have been locked out.");
                    }
                    }//end else
                }//end while
                    
        }//end main()
    }//end class
}//end mainspace
