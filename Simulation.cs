using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApp
{
    class Simulation
    {
        // -------------------------------- Member Variable -------------------------------
        public string firmName;
        public string userName;
        public string password;


        // -------------------------------- Constructor -----------------------------------

        public Simulation ()
	    {
            userName = "Admin";
            password = "Admin";
    	}


        // -------------------------------- Member Method ---------------------------------
        public void CreateMarketingFirmWithManager()
        {
            Console.WriteLine("Enter Your Firm Name.");
            this.firmName = Console.ReadLine();
            Console.WriteLine("Enter Your User Name.");
            this.userName = Console.ReadLine();
            Console.WriteLine("Please Create a Password.");
            this.password = Console.ReadLine();
        }
    }
}
