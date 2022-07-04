using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePerformanceTest.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }
        [StringLength(40)]
        public string MiddleInitial { get; set; }
        [Required]
        [StringLength(40)]
        public string LastName { get; set; }
    }
}
