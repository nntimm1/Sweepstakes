using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApp
{
    public class Sweepstakes 
    {
        // -------------------------------- Member Variable -------------------------------

        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        string nameOfSweepstakes;
        Random random = new Random();
        public int sweepstakesWinner;

        // -------------------------------- Constructor -----------------------------------

        public Sweepstakes()
        {

        }


        // -------------------------------- Member Method ---------------------------------
        public string AddNewSweepstakes(object contestantRegistration)
        {
            nameOfSweepstakes = Console.ReadLine();
            return nameOfSweepstakes;
         
        }
        public void ContestantRegistration()
        {
            UserInterface.ContestantAdd();
        }
        public int PickAWinner()
        {
            sweepstakesWinner = random.Next(0, 5000);
            return sweepstakesWinner;
        }
        public void PrintContestant()
        {
            Console.WriteLine("The Winner Is : " +sweepstakesWinner);
            Console.WriteLine("Congratulations " + UserInterface.firstName +" " + UserInterface.lastName);
        }
    }
}
