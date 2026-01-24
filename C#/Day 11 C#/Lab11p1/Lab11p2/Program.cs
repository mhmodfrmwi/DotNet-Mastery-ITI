using System;

namespace Lab11p2
{
    internal class Program
    {
        class Employee
        {
            public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
           
            protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
            {
                EmployeeLayOff.Invoke(this, e);
            }
            public int EmployeeID { get; set; }
            public DateTime BirthDate {get; set; }
            public int VacationStock { get; set; }
            public bool RequestVacation(DateTime From, DateTime To)
            {
                TimeSpan vacation = To - From;  
                int days=vacation.Days;
                VacationStock-=days;
                Console.WriteLine($"Employee {EmployeeID} requested {days} days. Remaining Stock: {VacationStock}");
                if (VacationStock<0)
                {
                    EmployeeLayOffEventArgs args = new EmployeeLayOffEventArgs
                    {
                        Cause = LayOffCause.vacations
                    };
                    OnEmployeeLayOff(args);
                    return false;
                }
                return true;
            }
            public void EndOfYearOperation()
            {
                int age = DateTime.Now.Year - BirthDate.Year;
                if (age>60)
                {
                    EmployeeLayOffEventArgs args = new EmployeeLayOffEventArgs
                    {
                        Cause = LayOffCause.age60
                    };
                    OnEmployeeLayOff(args);
                }
            }
        }
        public enum LayOffCause
        { 
            ///Implement it YourSelf
            vacations,
            age60
        }
        public class EmployeeLayOffEventArgs:EventArgs
        {
            public LayOffCause Cause { get; set; }
        }

        //Department
        // Employee should be removed from Department Staff List in both
        //Cases
        // If Employee Vacation Stock< 0
        // If Employee Age > 60

        class Department
        {
            public int DeptID { get; set; }
            public string DeptName { get; set; }
            List<Employee> Staff;
            public Department()
            {
                Staff = new List<Employee>();
            }
            public void AddStaff(Employee E)
            {
                Staff.Add(E);
                E.EmployeeLayOff += RemoveStaff;
                ///Try Register for EmployeeLayOff Event Here
            }
            ///CallBackMethod
            public void RemoveStaff(object sender,EmployeeLayOffEventArgs e)
            {
                Employee employee =sender as Employee; 
                if (employee!=null)
                {
                    Staff.Remove(employee);
                    Console.WriteLine($"Employee {employee.EmployeeID} removed! Cause: {e.Cause}");
                }
            }
        }

        //Club
        // Employee should be removed from Club Member List Only if Employee
        //Vacation Stock< 0.
        // If Employee Age> 60 will still remain a Member of Company Club
        class Club
        {
            public int ClubID { get; set; }
            public String ClubName { get; set; }
            List<Employee> Members;
            public Club()
            {
                Members = new List<Employee>();
            }
            public void AddMember(Employee E)
            {
                Members.Add(E);
                E.EmployeeLayOff += RemoveMember;     
                ///Try Register for EmployeeLayOff Event Here
            }
            ///CallBackMethod
            public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
            {
                Employee employee = sender as Employee;
                if (employee != null) {
                    return;
                }
                if (e.Cause==LayOffCause.vacations)
                {
                    Members.Remove(employee);
                    Console.WriteLine("employee removed due vacations");
                }
                else
                {
                    Console.WriteLine("employee not removed because age");
                }
                ///Employee Will not be removed from the Club if Age>60
                ///Employee will be removed from Club if Vacation Stock < 0
            }
        }
        static void Main(string[] args)
        {
            Department dept = new Department() { DeptID = 1, DeptName = "IT" };
            Club club = new Club() { ClubID = 100, ClubName = "Barcelona" };

            Employee emp1 = new Employee() { EmployeeID = 1, VacationStock = 5, BirthDate = new DateTime(1990, 1, 1) };
            Employee emp2 = new Employee() { EmployeeID = 2, VacationStock = 6, BirthDate = new DateTime(1955, 1, 1) };

            dept.AddStaff(emp1);
            club.AddMember(emp1);

            dept.AddStaff(emp2);
            club.AddMember(emp2);

            emp1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));

            emp2.EndOfYearOperation();

        }
    }
}
