using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class EmployeeAttendance
    {
        public static void GetAttendence()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHours = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 1)
            {
                empHours = 8;
            }
            else
            {
                empHours = 0;
            }
            int empWage = empHours * EMP_RATE_PER_HOUR;
            Console.WriteLine(  "empwage is : "+empWage );
        }
    }
}
