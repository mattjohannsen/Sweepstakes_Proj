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
            //add contestant to Dictionary
            //contestant.FirstName = Console.Readline();
        }
        public Contestant PickWinner()
        {
            //MarketingFirm theFirm = new MarketingFirm();
            //int numberOfSweepStakes = theFirm._manager.GetSweepstakesCount();
            //foreach (sweepstake in sweepstakes)
            //Sweepstakes sweepstakes = new Sweepstakes("test");
            //Contestant contestant = null;
            //theFirm._manager.GetSweepstakes(sweepstakes);
            // Go to appropriate Sweepstake Manager and find our appropriate Sweepstake

            //Once we get the correct Sweepstakes, the get the count
            //int sweepstakesCount = theFirm._manager.sweepstakesGetSweepstakesCount();
            Contestant winner = null;
            int sweepstakesCount = contestants.Count;
            int result;
            Random rnd = new Random();
            result = rnd.Next(0, sweepstakesCount);
            int key = result;
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key == key)
                    winner = contestant.Value;
                    Console.WriteLine("Month " + contestant.Key + " is of season " + contestant.Value);
            }
            return winner;

            //Generate a random number between 1 and the Count
            //This is the key to the customer that we want to notify that they won.


            //string key = (Console.ReadLine());

            //foreach (KeyValuePair<string, string> month in monthsInSeason)
            //{
            //    if (month.Key == key)
            //        Console.WriteLine("Month " + month.Key + " is of season " + month.Value);
            //}

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
