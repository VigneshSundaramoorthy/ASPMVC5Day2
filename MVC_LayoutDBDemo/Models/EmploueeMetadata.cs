using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_LayoutDBDemo.Models
{
    public class EmploueeMetadata
    {
        [Required(ErrorMessage ="Compulsory field")]
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<int> DeptID { get; set; }

        public virtual Department Department { get; set; }
    }
}