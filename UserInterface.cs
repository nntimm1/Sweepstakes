using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApp
{
    class UserInterface
    {
        // -------------------------------- Member Variable -------------------------------
        public Contestants newContestant;
        public int registrationNumber;
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string tempEmailAddress;



        // -------------------------------- Constructor -----------------------------------
        public UserInterface()
        {
            registrationNumber = 0;
        }




        // -------------------------------- Member Method ---------------------------------
        public void GetFirstName()
        {
            Console.WriteLine("Enter Contestant First Name:");
            firstName = Console.ReadLine();
        }
        public void GetLastName()
        {
            Console.WriteLine("Enter Contestant Last Name:");
            lastName = Console.ReadLine();
        }
        public void GetEmailAddress()
        {
            this.emailAddress = tempEmailAddress;
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
            else { return; }
        }
        public int GetRegistrationNumber()
        {
            registrationNumber++;
            Console.WriteLine("The registration Number for this COntestant is: " + registrationNumber);
            return registrationNumber;
        }
        public Contestants ContestantAdd(int registration, string first, string last, string email)
        {
            newContestant = new Contestants(registration, first, last, email);
            return newContestant;
        }
    }
}