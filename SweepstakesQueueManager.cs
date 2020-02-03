using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApp
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        // -------------------------------- Member Variable -------------------------------
        Queue<Sweepstakes> queue;


        // -------------------------------- Constructor -----------------------------------




        // -------------------------------- Member Method ---------------------------------
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
            
           
        }
    }
}
