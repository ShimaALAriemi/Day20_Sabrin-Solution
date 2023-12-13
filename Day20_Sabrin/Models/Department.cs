using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_Sabrin.Models
{
     class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Dep_Id { get; set; }
        [StringLength(80,MinimumLength =10)]
        public string Dep_Name { get; set; }
        public int Dep_Floor { get; set; }
        public ICollection<Employee> EmployeeDepartment { get; set; } = new List<Employee>();
    }
}
