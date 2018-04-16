using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArrays
{
    class Program
    {
        //Matthew Dal Santo
        //ITDEV115
        //Assignment 2A

        //App displays exactly as the example StudentApp.zip Application dictated.
        //Weekday names were truncated as formatting was odd otherwise.
        //All methods returning values only have one return statement as dictated in previous assignment grading notes.

        //Main will instatiate a StudentUI Class and Call the Main Method.
        static void Main(string[] args)
        {
            Info Assignment2AInfo = new Info();
            StudentUI RunApp = new StudentUI();

            Assignment2AInfo.DisplayInfo("Assignment2AInfo #2A - Practice Arrays");

            RunApp.MainMethod();
        }
    }
}
