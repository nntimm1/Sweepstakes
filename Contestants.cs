using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApp
{
    public class Contestants
    {
        // -------------------------------- Member Variable -------------------------------
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;


        // -------------------------------- Constructor -----------------------------------

        public Contestants(int registration, string first, string last, string email)
        {
            firstName = first;
            lastName = last;
            emailAddress = email;
            registrationNumber = registration;
        }


        // -------------------------------- Member Method ---------------------------------
    }
}
