using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_resources_department_at_the_university
{
    public enum Position
    {
        Professor,
        AssociateProfessor,
        Assistant,
        Lecturer
    }
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    abstract public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Gender Gender { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
    }

    public class Student: Human
    {
        public List<Parents> Parents { get; set; }
        public Group StudentGroup { get; set; }
    }
    public class Teachers : Human
    {
        public Department Department { get; set; }
        public Position Position { get; set; }
    }
    public class Group
    {
        public string NameGroup { get; set; }
        public List<Student> Students { get; set; }
        public Student GroupLeader { get; set; }
    }
    public class Parents: Human
    {
        public List<Student> Children { get; set; }
    }
}
