using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librian : User
    {
        public int? EmployeeNum {  get; set; }

        public Librian (string name, int? employeeNum)
        {
            Name = name;
            EmployeeNum = employeeNum;

        }
    }
}
