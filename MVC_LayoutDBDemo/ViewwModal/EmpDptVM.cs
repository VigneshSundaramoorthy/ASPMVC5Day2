using MVC_LayoutDBDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_LayoutDBDemo.ViewwModal
{
    public class EmpDptVM
    {
        public Employee Emp { get; set; }
        public Department Dept { get; set; }

        int age = 0;

        public int Age { get
            {
                age = DateTime.Now.Year - Emp.BirthDate.Value.Year;
                if(Emp.BirthDate > DateTime.Now.AddYears(-age))
                {
                    age--;
                }
                return age;
            } }

        public string SalaryColor { get
            {
                if (Emp.Salary > 25000)
                    return "lightgreen";
                else
                    return "lightpink";
            } }
    }
}