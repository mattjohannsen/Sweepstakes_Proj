using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface ISubscriber
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void Notify(ISubscriber subscriber);
    }
}
