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
        public void CreateSweepstake()
        {
            Console.WriteLine("       What do you want to call you new Sweepstakes?");
            string sweepstakesName = Console.ReadLine();
            Sweepstakes sweepstakes = new Sweepstakes(sweepstakesName);

        }
    }
}
