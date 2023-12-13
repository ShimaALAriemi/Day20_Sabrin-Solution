using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_Sabrin.Models
{
    internal class Projects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Projects_Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
     
        public ICollection<Employee> EmplyeeProject { get; set; } = new List<Employee>();
    }
}
