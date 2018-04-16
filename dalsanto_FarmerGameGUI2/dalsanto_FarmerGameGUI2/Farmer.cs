using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalsanto_FarmerGameGUI2
{
    enum Direction { North, South };

    class Farmer
    {
        //Matthew Dal Santo
        //ITDEV115
        //Assignment 3A

        //Nested Type Enum
        private Direction farmer;
        private List<string> northBank = new List<string>();
        private List<string> southBank = new List<string>();

        public Direction TheFarmer { get { return farmer; } set { farmer = value; } }
        public List<string> NorthBank { get { return northBank; } set { northBank = value; } }
        public List<string> SouthBank { get { return southBank; } set { southBank = value; } }


        public Farmer()
        {
            northBank.Add("FOX");
            northBank.Add("CHICKEN");
            northBank.Add("GRAIN");
            farmer = Direction.North;
        }

        public int AnimalAteFood()
        {
            int tempInt = 0;

            if (farmer == Direction.North && southBank.Count > 1)
            {
                for (int i = 0; i < southBank.Count; i++)
                {
                    if (southBank[i] == "FOX") { tempInt = tempInt + 1; }
                    if (southBank[i] == "CHICKEN") { tempInt = tempInt + 3; }
                    if (southBank[i] == "GRAIN") { tempInt = tempInt + 5; }
                }
            }
            else if (farmer == Direction.South && northBank.Count > 1)
            {
                for (int i = 0; i < northBank.Count; i++)
                {
                    if (northBank[i] == "FOX") { tempInt = tempInt + 1; }
                    if (northBank[i] == "CHICKEN") { tempInt = tempInt + 3; }
                    if (northBank[i] == "GRAIN") { tempInt = tempInt + 5; }
                }
            }

            if (DetermineWin()) { return 1; }
            else if (tempInt == 4 || tempInt == 8) { return tempInt; }
            else if (farmer == Direction.South && northBank.Count == 3 && tempInt == 9) { return 4; }
            else { return 0; }
        }

        //Above would have been a lot cleaner, but I wanted to stay true to the UML
        //and use the below method.
        public bool DetermineWin()
        {
            int tempInt = 0;

            for (int i = 0; i < southBank.Count; i++)
            {
                if (southBank[i] == "FOX") { tempInt = tempInt + 1; }
                if (southBank[i] == "CHICKEN") { tempInt = tempInt + 3; }
                if (southBank[i] == "GRAIN") { tempInt = tempInt + 5; }
            }

            if (tempInt == 9) { return true; }
            else { return false; }
        }

        public int Move(string carry)
        {
            int tempInt = 0;

            //0: keep going, 1: win, 4: Fox ate Chicken, 8: Chicken ate Grain
            if (carry == "")
            {
                if (farmer == Direction.North) { farmer = Direction.South; }
                else if (farmer == Direction.South) { farmer = Direction.North; }
            }
            else if (farmer == Direction.North)
            {
                northBank.Remove(carry.ToUpper());
                southBank.Add(carry.ToUpper());
                farmer = Direction.South;
            }
            else if (farmer == Direction.South)
            {
                southBank.Remove(carry.ToUpper());
                northBank.Add(carry.ToUpper());
                farmer = Direction.North;
            }

            tempInt = AnimalAteFood();
            if (tempInt > 0)
            {
                northBank.Clear();
                southBank.Clear();
                farmer = Direction.North;
                northBank.Add("FOX");
                northBank.Add("CHICKEN");
                northBank.Add("GRAIN");
            }
            return tempInt;
        }
    }
}
