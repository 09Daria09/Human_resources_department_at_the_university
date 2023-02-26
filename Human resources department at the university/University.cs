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
        public University() { }
        public University(List<Faculty> faculties)
        {
            Faculties = faculties;
        }
    }
    public class Faculty
    {
        public string NameFacuity { get; set; }
        public List<Department> Departments { get; set; }
        public Faculty() { }
        public Faculty(string nameFacuity, List<Department> departments)
        {
            NameFacuity = nameFacuity;
            Departments = departments;
        }

    }
    public class Department
    {
        public string NameDepartment { get; set; }
        public Teachers Head { get; set; }
        public bool IsProfiling { get; set; }
        public List<Group> StudentGroups { get; set; }
        public List<Teachers> Teachers { get; set; }
        public Department() 
        {
            NameDepartment = null;
            Head = null;
            IsProfiling = false;
            StudentGroups = null;
            Teachers = null;
        }
        public Department(string nameDepartment, Teachers head, bool isProfiling, List<Group> studentGroups, List<Teachers> teachers) 
        {
            NameDepartment = nameDepartment;
            Head = head;
            IsProfiling = isProfiling;
            StudentGroups = studentGroups;
            Teachers = teachers;
        }

    }

}
