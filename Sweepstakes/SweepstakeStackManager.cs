﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakeStackManager : ISweepStakesManager
    {
        private Stack<Sweepstakes> stack;

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
