using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class Employee
    {
        private string employeeId;
        private string employeeName;
        private int employeeExperience;

        public string EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public string EmployeeName { get { return employeeName; } set { employeeName = value; } }
        public int EmployeeExperience { get { return employeeExperience; } set { employeeExperience = value; } }


        public Employee()
        {
            this.EmployeeId = null;
            this.EmployeeName = null;
            this.EmployeeExperience = 0;
        }

        public Employee(string employeeId, string employeeName, int employeeExperience)
        {
            this.EmployeeName = employeeName;
            this.EmployeeExperience = employeeExperience;
            this.EmployeeId = employeeId;
        }
    }
}
