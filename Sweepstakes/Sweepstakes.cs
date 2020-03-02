using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            Console.WriteLine($"       OFFICIAL REGISTRATION");
            Console.WriteLine($"       What is your first name?");
            //contestant.FirstName = Console.Readline();
        }
        //public Contestant PickWinner()
        //{

        //}
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"       This is the Contestant's info:");
            Console.WriteLine($"           First Name: {contestant.FirstName}");
            Console.WriteLine($"            Last Name: {contestant.LastName}");
            Console.WriteLine($"        Email Address: {contestant.EmailAddress}");
            Console.WriteLine($"       Registration #: {contestant.RegistrationNumber}");
        }
    }
}
