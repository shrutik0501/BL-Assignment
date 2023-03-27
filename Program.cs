namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            EmployeeAttendance.computeEmpWage("dmart",20,20,100);
            EmployeeAttendance.computeEmpWage("reliance", 25, 18, 95);

        }
    }
}