using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SportingEventApp
{
    class SportingEventAppModel
    {
        //Sports
        private List<string> sports = new List<string>
        {
            "Skiing", "Baseball", "Basketball", "Football", "Soccer"
        };
        public List<string> GetSports() { return sports; }
        public string GetSports(int i) { return sports[i]; }

        //Sports Messages
        private List<string> sportsMessage = new List<string>
        {
            //Skiing
            "Taste that sweet powder on a chill milk run, bro.",
            //Baseball
            "Don't play hardball.  Sign up and hit a home run right off the bat!",
            //Basketball
            "Land an easy layup and sign up for this full court press pick!",
            //Football
            "Don't be an armchair quaterback!  Push it over the goal line and sign up!",
            //Soccer
            "Don't miss a sitter!  Take this chance to play out of your skin!"
        };
        public List<string> GetSportsMessage() { return sportsMessage; }
        public string GetSportsMessage(int i) { return sportsMessage[i]; }

        //Registered Student Lists
        private List<string> name = new List<string>();
        public List<string> GetName() { return name; }
        public void SetName(string str) { name.Add(str); }

        private List<string> address = new List<string>();
        public List<string> GetAddress() { return address; }
        public void SetAddress(string str) { address.Add("Address: " + str); }

        private List<string> city = new List<string>();
        public List<string> GetCity() { return city; }
        public void SetCity(string str) { city.Add("City: " + str); }

        private List<string> state = new List<string>();
        public List<string> GetState() { return state; }
        public void SetState(string str) { state.Add("State: " + str); }

        private List<string> sport = new List<string>();
        public List<string> GetSport() { return sport; }
        public void SetSport(string str) { sport.Add("Sport: " + str); }

        //Random Values
        private List<string> rndFirstName = new List<string>
        {
            "Sophia", "Emma", "Olivia", "Ava", "Mia",
            "Isabella", "Riley", "Aria", "Zoe", "Charlotte",
            "Jackson", "Aiden", "Lucas", "Liam", "Noah",
            "Ethan", "Mason", "Caden", "Oliver", "Elijah"
        };
        public List<string> GetRndFirstName() { return rndFirstName; }
        public string GetRndFirstName(int i) { return rndFirstName[i]; }

        private List<string> rndLastName = new List<string>
        {
            "Smith", "Johnson", "Williams", "Jones", "Brown",
            "Davis", "Miller", "Wilson", "Moore", "Taylor"
        };
        public List<string> GetRndLastName() { return rndLastName; }
        public string GetRndLastName(int i) { return rndLastName[i]; }

        private int rndAddressNumberMax = 2000;
        public int GetRndAddressNumberMax() { return rndAddressNumberMax; }

        private List<string> rndDirection = new List<string>
        {
            "North", "East", "South", "West"
        };
        public List<string> GetRndDirection() { return rndDirection; }
        public string GetRndDirection(int i) { return rndDirection[i]; }

        private List<string> rndStreet = new List<string>
        {
            "Pine", "Maple", "Cedar", "Elm", "Park",
            "Washington", "Main", "Lake", "Oak", "Hill"
        };
        public List<string> GetRndStreet() { return rndStreet; }
        public string GetRndStreet(int i) { return rndStreet[i]; }

        private List<string> rndStreetType = new List<string>
        {
            "Avenue", "Boulevard", "Road", "Street", "Court"
        };
        public List<string> GetRndStreetType() { return rndStreetType; }
        public string GetRndStreetType(int i) { return rndStreetType[i]; }

        private List<string> rndCity = new List<string>
        {
            "Madison", "Milwaukee", "New York", "Seattle", "Las Vegas",
            "San Francisco", "New Orleans", "Denver", "Memphis", "Detroit"
        };
        public List<string> GetRndCity() { return rndCity; }
        public string GetRndCity(int i) { return rndCity[i]; }

        public void ClearReg()
        {
            name.Clear();
            address.Clear();
            city.Clear();
            state.Clear();
            sport.Clear();
        }
    }
}
