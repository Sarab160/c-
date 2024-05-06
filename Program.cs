using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_attendence
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        public void displayinfo()
        {
            Console.WriteLine($"Employee Id: {EmployeeID} Employee Name: {Name}");
        }
        class Attendance
        {
            public DateTime attendanceDate { get; set; }
            public Boolean ispresent { get; set; }

            public void Markattendance()
            {
                if (ispresent)
                {
                    Console.WriteLine($"Attendance date is: {attendanceDate} Employee  is present true aor false : {ispresent}");
                }
                else
                {
                    Console.WriteLine($"Attendance date is: {attendanceDate} Employee  is present true or false : {ispresent}");
                }
            }

        }
        abstract class Payment
        {
            public DateTime Paymentdate { get; set; }

            public int Amount { get; set; }

            public abstract void calculatepayment();

        }

        class hourlypayemnt : Payment
        {
            public int hourrlrate { get; set; }

            public override void calculatepayment()
            {
                Console.WriteLine($"Payment date : {Paymentdate} and his hourly rate is: {hourrlrate}");
            }
        }
        class salary : Payment
        {
            public int monthlysalary {  get; set; }

            public override void calculatepayment()
            {
                Console.WriteLine($"Payment date : {Paymentdate} and his hourly rate is: {monthlysalary}");
            }
        }

        class Attendancesystem
        {
            public void details(Employee employee)
            {
                employee.displayinfo();
            }

            public void attendacesystem(Attendance attendance)
            {
                attendance.Markattendance();
            }
            public void hourlypayment(hourlypayemnt payement)
            {
                payement.calculatepayment();
            }
            public void salarymonth(salary monthlysalary)
            {
                monthlysalary.calculatepayment();
            }
        }
            internal class Program
        {
            static void Main(string[] args)
            {
                Employee employee1 = new Employee { EmployeeID = 23, Name = "john" };
                Employee employee2 = new Employee { EmployeeID = 24, Name = "jack" };

                Attendance att1 = new Attendance { attendanceDate = DateTime.Now,ispresent =  true };
                Attendance att2 = new Attendance { attendanceDate = DateTime.Now, ispresent = true };

                hourlypayemnt pay1 = new hourlypayemnt { Paymentdate = DateTime.Now,hourrlrate =567 };
                hourlypayemnt pay2 = new hourlypayemnt { Paymentdate = DateTime.Now, hourrlrate = 345 };

                salary sal1 = new salary { Paymentdate = DateTime.Now ,monthlysalary = 567876};
                salary sal2 = new salary { Paymentdate = DateTime.Now, monthlysalary = 145876 };

                Attendancesystem attendancesystem = new Attendancesystem();

                Console.WriteLine("Press Enter to check first Employee details");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" ");
                Console.ReadLine();

                attendancesystem.details(employee1);
                attendancesystem.attendacesystem(att1);
                attendancesystem.hourlypayment(pay1);
                attendancesystem.salarymonth(sal1);
                Console.WriteLine(" ");
                Console.WriteLine("Press Enter to check Second Employee details");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" ");
                Console.ReadLine();

                attendancesystem.details(employee2);
                attendancesystem.attendacesystem(att2);
                attendancesystem.hourlypayment(pay2);
                attendancesystem.salarymonth(sal2);
                Console.ReadLine();
            }
        }
    }
}
