using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Task01
{
    internal class Employee
    {
        public string SSN { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Salary { get; set; }
        public int Dno { get; set; }
        public string FullName => $"{Fname} {Lname}";
    }
}
