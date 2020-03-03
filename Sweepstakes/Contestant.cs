using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : ISubscriber
    {
        private string firstname;
        public string FirstName
        {
            get {  return firstname;  }
            set { firstname = value;  }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set {  lastName = value; }
        }

        private string emailAddress;
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private int registrationNumber;
        public int RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        public void Notify(ISubscriber subscriber)
        {
            Console.WriteLine($"{subscriber.FirstName} {subscriber.LastName} was the winner of the Sweepstakes.  Thank you for playing.");
        }
        public void Notify(ISubscriber subscriber, bool isWinner)
        {
            Console.WriteLine($"{subscriber.FirstName} {subscriber.LastName}, you are the winner of the Sweepstakes!  We will contact you soon regarding your prizes!");
        }

    }
}
