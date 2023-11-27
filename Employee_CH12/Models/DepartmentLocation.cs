using Employee_CH12.Models;

namespace Employee_CH12.Models
{
    public class DepartmentLocation
    {
        //composition primary key and foreign key for Department
        public int DepartmentID {  get; set; }
        //composition primary key and foreign key for location
        public int LocationID {  get; set; }

        //navi property
        public Department Department { get; set; } = null!;
        public Location Location { get; set; } = null!;
    }
}
