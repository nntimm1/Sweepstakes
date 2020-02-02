using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApp
{
    class Sweepstakes 
    {
        // -------------------------------- Member Variable -------------------------------

        Dictionary<string, string> sweepstakes = new Dictionary<string, string>();
        string nameOfSweepstakes;
        Random random = new Random();
        int maxRegistrationNumber;

        // -------------------------------- Constructor -----------------------------------

        public Sweepstakes()
        {
            
        }


        // -------------------------------- Member Method ---------------------------------
        public void AddNewSweepstakes()
        {
            nameOfSweepstakes = Console.ReadLine();
        }
        public void ContestantRegistration()
        {

        }
        public void PickAWinner()
        {
            random.Next(0,maxRegistrationNumber);


        }
        public void PrintContestand()
        {
            Console.WriteLine();
        }
        public void ContestantRegister()
        {

        }






    }
}
