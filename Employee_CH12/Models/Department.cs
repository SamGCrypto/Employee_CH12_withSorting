using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Employee_CH12.Models;

namespace Employee_CH12.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Department")]
        public string Name { get; set; } = string.Empty;
        //navi property
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        //Navi Property
        public ICollection<DepartmentLocation> DepartmentLocation { get; set; } = new List<DepartmentLocation>();
    }
}