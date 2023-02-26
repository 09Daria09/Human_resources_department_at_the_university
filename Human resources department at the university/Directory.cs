using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_resources_department_at_the_university
{
    public class Directory
    {
        public List<Student> Students { get; set; }
        public List<Teachers> Teachers { get; set; }
        public List<Parents> Parents { get; set; }
        public List<Faculty> Faculties { get; set; }
        public List<Student> listChildren { get; set; }

        public Directory()
        {
            Students = new List<Student>();
            Teachers = new List<Teachers>();
            Parents = new List<Parents>();
            Faculties = new List<Faculty>();
            listChildren = new List<Student>();
        }

        public List<Student> GetSortedStudents(string sortBy)
        {
            switch (sortBy)
            {
                case "ФИО":
                    return Students.OrderBy(s => s.Name).ThenBy(s => s.Surname).ThenBy(s => s.Patronymic).ToList();
                case "Факультет":
                    return Students.OrderBy(s => s.StudentGroup.ProfileDepartment).ThenBy(s => s.StudentGroup.NameGroup).ToList();
                case "Группа":
                    return Students.OrderBy(s => s.StudentGroup.NameGroup).ThenBy(s => s.Surname).ThenBy(s => s.Name).ThenBy(s => s.Patronymic).ToList();
                default:
                    return Students.OrderBy(s => s.Surname).ThenBy(s => s.Name).ThenBy(s => s.Patronymic).ToList();
            }
        }
        public List<Teachers> GetSortedTeachers(string sortBy)
        {
            switch (sortBy)
            {
                case "Имя":
                    return Teachers.OrderBy(t => t.Surname).ThenBy(t => t.Name).ThenBy(t => t.Patronymic).ToList();
                case "Факультет":
                    return Teachers.OrderBy(t => t.Department.IsProfiling).ThenBy(t => t.Department.NameDepartment).ThenBy(t => t.Surname).ThenBy(t => t.Name).ThenBy(t => t.Patronymic).ToList();
                case "Кафедра":
                    return Teachers.OrderBy(t => t.Department.NameDepartment).ThenBy(t => t.Surname).ThenBy(t => t.Name).ThenBy(t => t.Patronymic).ToList();
                default:
                    return Teachers.OrderBy(t => t.Surname).ThenBy(t => t.Name).ThenBy(t => t.Patronymic).ToList();
            }
        }

        public List<Teachers> GetDepartmentHeads()
        {
            return Teachers.Where(t => t.Department.IsProfiling).ToList();
        }        

        public List<Student> GetChildrenOfParent(Parents parent)
        {
            return Students.Where(s => s.Parents.Contains(parent)).ToList();
        }
        public List<Student> GetTeachersWithStudentChildren()
        {
            return listChildren.OrderBy(s => s.Name).ThenBy(s => s.Surname).ThenBy(s => s.Patronymic).ToList();
        }
    }

}
