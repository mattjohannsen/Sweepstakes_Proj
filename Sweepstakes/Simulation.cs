using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        MarketingFirm theFirm;

        public void RunSimulation()
        {
            Console.WriteLine("       Sweepstakes Manager 1.0");
            CreateMarketingFirmWithManager();
            
            //theFirm.CreateSweepstake();




        }
        public void CreateMarketingFirmWithManager()
        {
            Console.WriteLine();
            Console.WriteLine("       Select your Sweepstakes Manager type:");
            Console.WriteLine("       Type 'stack' for Stack Manager (LIFO)");
            Console.WriteLine("       Type 'queue' for Queue Manager (FIFO)");
            string managerChoice;
            managerChoice = Console.ReadLine();
            ISweepStakesManager manager = null;
            switch (managerChoice)
            {
                case "stack":
                    manager = new SweepstakeStackManager();
                    break;
                case "queue":
                    manager = new SweepstakeQueueManager();
                    break;
                default:
                    Console.WriteLine("       That is not a valid choice. Select stack or queue.");
                    CreateMarketingFirmWithManager();
                    break;
            }
            MarketingFirm theFirm = new MarketingFirm(manager);
        }
    }
}
