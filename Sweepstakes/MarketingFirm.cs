using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepStakesManager _manager;

        public MarketingFirm()
        {

        }
        public MarketingFirm(ISweepStakesManager manager)
        {
            _manager = manager;
            //if (firmType == "stack")
            //{
            //    SweepstakeStackManager sweepstakesStackManager = new SweepstakeStackManager();
            //    _manager = sweepstakesStackManager;
            //}
            //if (firmType == "queue")
            //{
            //    SweepstakeQueueManager sweepstakeQueueManager = new SweepstakeQueueManager();
            //    _manager = sweepstakeQueueManager;
            //}
        }
        public void CreateSweepstake()
        {
            Console.WriteLine("       What do you want to call your new Sweepstakes?");
            string sweepstakesName = Console.ReadLine();
            Sweepstakes sweepstakes = new Sweepstakes(sweepstakesName);
            _manager.InsertSweepstakes(sweepstakes);
            //InsertSweepstakes(sweepstakes);

        }
    }
}
