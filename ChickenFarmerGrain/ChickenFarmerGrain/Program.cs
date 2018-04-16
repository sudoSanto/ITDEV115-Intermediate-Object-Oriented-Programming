using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenFarmerGrain
{
    class Program
    {
        //Matthew Dal Santo
        //ITDEV115
        //Assignment 3

        static void Main(string[] args)
        {
            Info AssignmentInfo = new Info();
            FarmerUI FarmerMain = new FarmerUI();

            AssignmentInfo.DisplayInfo("Assignment 3 - Chicken Farmer Grain");
            FarmerMain.PlayGame();
        }
    }
}
