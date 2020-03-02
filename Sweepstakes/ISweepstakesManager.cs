using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface ISweepStakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        void GetSweepstakes();

    }
}
