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
            int IS_PART_TIME  = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int NUM_OF_WORKING_DAYS = 20;
            int empHrs = 0;
            int empWage = 0;

            int totalEmpWage = 0;
            int totalEmpHours = 0;


            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {


                Random random = new Random();
                int empCheck = random.Next(0, 3);
                if (empCheck == IS_PART_TIME)
                {
                    empHrs = 4;
                }
                else if (empCheck == IS_FULL_TIME)
                {
                    empHrs = 8;
                }
                totalEmpHours=totalEmpHours+empHrs;
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("empwage  : " + empWage);
            }
            totalEmpWage=totalEmpHours*EMP_RATE_PER_HOUR;
            Console.WriteLine("Total EmpWage is : "+totalEmpWage);

        }
    }
}
