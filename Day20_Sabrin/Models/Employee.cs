using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_Sabrin.Models
{
     class Employee { 

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Employee_Id { get; set; }
        [MaxLength(50)]
        public string Employee_Name { get; set;}
        [Range(18, 50)]
        public int Employee_Age { get; set;}

        [DataType(DataType.Currency)]
        public decimal Employee_Salary { get; set;}

        [ForeignKey("Departments")]
        public int? DepId { get; set; }
        public Department Departments { get; set; }

        public ICollection<Projects> projects { get; set; } = new List<Projects>();
    }
}
