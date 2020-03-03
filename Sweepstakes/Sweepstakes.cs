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
            Contestant contestant = null;
            // Go to appropriate Sweepstake Manager and find our appropriate Sweepstake
            //Once we get the correct Sweepstakes, the get the count
            //Generate a random number between 1 and the Count
            //This is the key to the customer that we want to notify that they won.


            string key = (Console.ReadLine());

            //foreach (KeyValuePair<string, string> month in monthsInSeason)
            //{
            //    if (month.Key == key)
            //        Console.WriteLine("Month " + month.Key + " is of season " + month.Value);
            //}
            return contestant;
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
