﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakeQueueManager : ISweepStakesManager
    {
        private Queue<Sweepstakes> queue;

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
