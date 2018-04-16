using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArrays
{
    class Student
    {
        //Matthew Dal Santo
        //ITDEV115
        //Assignment 2A

        public Student() { }

        private double[] hours = new double[7];

        private int id;
        public int ID { get { return id; } set { id = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        public double CalculateAvg()
        {
            double total = 0;
            for (int i = 0; i < hours.Length; i++)
            {
                total = total + hours[i];
            }
            return total / hours.Length;
        }

        public void EnterHours(int i, double num)
        {
            hours[i] = num;
        }

        public double GetNumberHours(int i)
        {
            return hours[i];
        }
    }
}
