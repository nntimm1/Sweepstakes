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
        public ISweepstakesManager CreateMarketingFirmWithManager()
        {
            Console.WriteLine("Which type of SweepStake would you like to use? \n Enter 'Stack' or 'Queue'");
            string userInput = Console.ReadLine();
            ISweepstakesManager manager = null;
            if ((userInput == "Stack") || (userInput == "stack"))
            {
                manager = new SweepstakesStackManager();
            }
            else if ((userInput == "Queue") || (userInput == "queue"))
            {
                manager = new SweepstakesQueueManager();
            }
            return manager;
        }

    }
}
