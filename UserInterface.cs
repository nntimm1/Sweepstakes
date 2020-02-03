using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApp
{
    static class UserInterface
    {
        // -------------------------------- Member Variable -------------------------------
        

        static public int registrationNumber = 0;
        static public string firstName;
        static public string lastName;
        static public string emailAddress;
        static public string tempEmailAddress;

        // -------------------------------- Constructor -----------------------------------


        // -------------------------------- Member Method ---------------------------------

        private static string GetFirstName()
        {
            Console.WriteLine("Enter Contestant First Name:");
            firstName = Console.ReadLine();
            return firstName;
        }
        private static string GetLastName()
        {
            Console.WriteLine("Enter Contestant Last Name:");
            lastName = Console.ReadLine();
            return lastName;
        }
        private static string GetEmailAddress()
        {
            
            Console.WriteLine("Enter Contestant Email Address:");
            tempEmailAddress = Console.ReadLine();
            if ((tempEmailAddress.Contains("@"))) { }
            else { Console.WriteLine("That was not a valid email address. Please Try again."); GetEmailAddress(); }
            if ((tempEmailAddress.Contains(".com")) || (tempEmailAddress.Contains(".net")) ||
               (tempEmailAddress.Contains(".gov")) || (tempEmailAddress.Contains(".biz")) ||
               (tempEmailAddress.Contains(".edu")) || (tempEmailAddress.Contains(".org")) ||
               (tempEmailAddress.Contains(".uk"))) { }
            else { Console.WriteLine("That was not a valid email address. Please Try again."); GetEmailAddress(); }
            if (tempEmailAddress.Contains(" "))
               {Console.WriteLine("That was not a valid email address. Please Try again."); GetEmailAddress();}
            else { }
            string[] splitString = tempEmailAddress.Split('@');
            if (splitString.Contains(""))
            {Console.WriteLine("That was not a valid email address. Please Try again."); GetEmailAddress();}
            else { 
                emailAddress = tempEmailAddress;
                }
            return emailAddress;
        }
        private static int GetRegistrationNumber()
        {
            registrationNumber++;
            Console.WriteLine("The registration Number for this Contestant is: " + registrationNumber);
            return registrationNumber;
        }
        public static Contestant ContestantAdd()  //Master Method 
        {
            newContestant = new Contestant();
            GetFirstName();
           
            GetLastName();
            
            GetEmailAddress();
            
            GetRegistrationNumber();
           
            return newContestant;
        }
    }
}