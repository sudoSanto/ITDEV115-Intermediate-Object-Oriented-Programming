using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalsanto_ElectionProgram_Midterm
{
    class Program
    {
        //Matthew Dal Santo
        //ITDEV115
        //Mid-Term

        static void Main(string[] args)
        {
            Info AssignmentInfo = new Info();
            ElectionUI ElectionMain = new ElectionUI();

            AssignmentInfo.DisplayInfo("Mid-Term Election Program");
            ElectionMain.MainMethod();
        }
    }
}
