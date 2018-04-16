using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArrays
{
    class StudentUI
    {
        //Matthew Dal Santo
        //ITDEV115
        //Assignment 2A

        public StudentUI() { }

        Student NewStudent = new Student();

        private string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

        //of study hours per week.
        public void DisplayAverage()
        {
            double avg = NewStudent.CalculateAvg();

            Console.Write("\n\n\nThe average number of hours studied per day was {0:N3}", avg);
        }

        //Display name id and Array contents...
        public void DisplayData()
        {
            double[] dayHours = new double[7];
            String name = NewStudent.Name;
            int id = NewStudent.ID;
            int tempCount = 0;

            for (int i = 0; i < dayHours.Length; i++)
            {
                dayHours[i] = NewStudent.GetNumberHours(i);
            }

            Console.Clear();
            Console.Write("\n\n\nName: " + name);
            Console.Write("\nID: " + id + "\n\n");

            do
            {
                Console.Write("\n\t" + days[tempCount] + "\t:\t{0:N2}", dayHours[tempCount]);
                tempCount++;
            } while (tempCount < 7);
        }

        //loop to prompt for input and add to the student classes array.
        public void FillHours()
        {
            string stringDay;
            double tempDouble = 0;
            int tempCount = 0;

            Console.Write("\n\n");
            do
            {
                Console.Write("Enter the number of hours that you studied ITDEV-115 on " + days[tempCount] + "\t:\t");
                stringDay = Console.ReadLine();
                while ((double.TryParse(stringDay, out tempDouble) != true))
                {
                    Console.Write("\nYou entered an invalid response!  Please try again");
                    Console.Write("\n\n\nEnter the number of hours that you studied ITDEV-115 on " + days[tempCount] + "\t:\t");
                    stringDay = Console.ReadLine();
                }
                NewStudent.EnterHours(tempCount, tempDouble);
                tempCount++;
            } while (tempCount < 7);
        }

        public void MainMethod()
        {
            string stringID;
            int tempID;

            Console.Write("Please enter your name: \t");
            NewStudent.Name = Console.ReadLine();

            Console.Write("Please enter your student id: \t");
            stringID = Console.ReadLine();
            while ((int.TryParse(stringID, out tempID) != true))
            {
                Console.Write("\nYou entered an invalid response!  Please try again");
                Console.Write("\n\n\nPlease enter your student id: \t");
                stringID = Console.ReadLine();
            }
            NewStudent.ID = tempID;

            FillHours();
            DisplayData();
            DisplayAverage();

            Console.ReadKey();
        }
    }
}
