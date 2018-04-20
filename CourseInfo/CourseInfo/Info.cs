using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfo
{
    public class Info
    {
        public void DisplayInfo(string assignment)
        {
            Console.Title = (assignment);
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("Name: \t\t\tMatthew Dal Santo");
            Console.WriteLine("Course: \t\tITDEV-115-200");
            Console.WriteLine("Instructor: \t\tMr. Hunsicker & Mr. Menzl");
            Console.WriteLine("Assignment: \t\t" + assignment);
            Console.WriteLine("Date: \t\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("**************************************************");
        }
    }
}
