using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public class Human 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Gender Gender { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
        public Human()
        {
            Name = null;
            Surname = null;
            Patronymic = null;
            Passport = null;
            Address = null;
        }
        public Human(string name, string surname, string patronymic, Gender gender, string passport, string address)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Gender = gender;
            Passport = passport;
            Address = address;
        }
        public virtual string ToString()
        {
            return $"ФИО: {Name} {Surname} {Patronymic}\nПол: {Gender}";
        }

    }
    public class Student: Human
    {
        public List<Parents> Parents { get; set; }
        public Group StudentGroup { get; set; }

        public Student() : base()
        {
            Parents = null;
            StudentGroup = null;
        }
        public Student(string name, string surname, string patronymic, Gender gender, string passport, string address, Group group, List<Parents> parents) : base (name,surname,patronymic,gender,passport,address)
        {
            StudentGroup = group;
            Parents = parents;
        }
        public Student(string name, string surname, string patronymic, Gender gender, string passport, string address, Group group) : base(name, surname, patronymic, gender, passport, address)
        {
            StudentGroup = group;
            Parents = null;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nГруппа: {StudentGroup.NameGroup}";
        }

    }
    public class Teachers : Human
    {
        public Department Department { get; set; }
        public Position Position { get; set; }

        public Teachers() : base()
        {
            Department = null;
        }
        public Teachers(string name, string surname, string patronymic, Gender gender, string passport, string address, Department department, Position position) : base(name, surname, patronymic, gender, passport, address)
        {
            Department = department;
            Position = position;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nФакультет: {Department.NameDepartment}\n Должность: {Position}";
        }
    }
    public class Group
    {
        public string NameGroup { get; set; }
        public Student GroupLeader { get; set; }
        public Department ProfileDepartment { get; set; }
        public Group()
        {
            NameGroup = null;
            GroupLeader = null;
            ProfileDepartment = null;
        }
        public Group(string nameGroup, Department profileDepartment, Student groupLeader)
        {
            NameGroup = nameGroup;
            ProfileDepartment = profileDepartment;
            GroupLeader = groupLeader;
        }
    }
    public class Parents: Human
    {
        public List<Student> Children { get; set; }
        public Parents() : base()
        {
            Children = null;
        }
        public Parents(string name, string surname, string patronymic, Gender gender, string passport, string address, List<Student> children) : base(name, surname, patronymic, gender, passport, address)
        {
            Children = children;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
