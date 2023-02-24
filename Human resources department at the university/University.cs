using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_resources_department_at_the_university
{
    public class University
    {
        public List<Faculty> Faculties { get; set; }
    }

    public class Faculty
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
        public Teachers Head { get; set; }
        public bool IsProfiling { get; set; }
        public List<Group> StudentGroups { get; set; }
        public List<Teachers> Teachers { get; set; }
    }
}
