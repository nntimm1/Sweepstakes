using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApp
{
    class MarketingFirm
    {
        // -------------------------------- Member Variable -------------------------------
        ISweepstakesManager Manager;


        // -------------------------------- Constructor -----------------------------------


        // -------------------------------- Member Method ---------------------------------

        
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes();

            Manager.InsertSweepstakes(sweepstakes);
        }
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.Manager = manager;
        }

    }
}
