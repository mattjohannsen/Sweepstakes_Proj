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
            contestant.FirstName = UserInterface.GetUserInputFor("First Name");
            contestant.LastName = UserInterface.GetUserInputFor("Last Name");
            contestant.EmailAddress = UserInterface.GetUserInputFor("Email Address");
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            Contestant winner = null;
            Contestant loser = null;
            int sweepstakesCount = contestants.Count;
            int result;
            Random rnd = new Random();
            result = rnd.Next(0, sweepstakesCount);
            int key = result;
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key != key)
                {
                    loser = contestant.Value;
                    loser.Notify(loser);
                }
                else
                {
                    winner = contestant.Value;
                    bool isWinner = true;
                    winner.Notify(winner, isWinner);
                }
            }
            return winner;
        }
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
