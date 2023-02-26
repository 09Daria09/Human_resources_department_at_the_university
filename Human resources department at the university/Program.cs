using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_resources_department_at_the_university
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory();
            Student student = new Student();
            //List<Student> listStudent = new List<Student>();
            //List<Parents> listParents = new List<Parents>();
            List<Group> listGroup = new List<Group>();
            //List<Teachers> listTeacher = new List<Teachers>();
            //List<Student> listChildren = new List<Student>();
            #region
            Group group214 = new Group("214-D", directory.Students, student);
            listGroup.Add(group214);
            Student student1 = new Student("Игорь", "Иванов", "Сергеевич", Gender.Male, "РН237583","Франкивский район 5Л",group214, directory.Parents);
            directory.Students.Add(student1);
            directory.listChildren.Add(student1);
            Student student2 = new Student("Валик", "Петрович", "Иванович", Gender.Male, "YU375900", "Залужный 45/4", group214, directory.Parents);
            directory.Students.Add(student2);
            directory.listChildren.Add(student2);
            Student student3 = new Student("Лиза", "Коуш", "Викторовна", Gender.Female, "NK476930", "Глушко 6/3", group214, directory.Parents);
            directory.Students.Add(student3);
            directory.listChildren.Add(student3);
            Student student4 = new Student("Кирилл", "Параманов", "Максимович", Gender.Male, "GH3284954", "Судковского 14А", group214);
            directory.Students.Add(student4);
            Student student5 = new Student("Катя", "Лучкина", "Денисовна", Gender.Female, "KI128673", "Колиновский 34Д", group214);
            directory.Students.Add(student5);

            Teachers teachershead = new Teachers();
            Department department = new Department("Математика", teachershead, true, listGroup, directory.Teachers);

            Group group211 = new Group("211-A", department, student);
            listGroup.Add(group211);
            Student student6 = new Student("Света", "Грушевская", "Валентиновна", Gender.Female, "AD4376113", "Марта 8", group211, directory.Parents);
            directory.Students.Add(student6);
            directory.listChildren.Add(student6);
            Student student7 = new Student("Леша", "Портуш", "Иванович", Gender.Male, "RT677723", "Свободы 123", group211);
            directory.Students.Add(student7);
            Student student8 = new Student("Дима", "Котуч", "Андреевич", Gender.Male, "QE113450", "Кушинского 78Ф", group211, directory.Parents);
            directory.Students.Add(student8);
            directory.listChildren.Add(student8);
            Student student9 = new Student("Антон", "Понамарев", "Максимович", Gender.Male, "RT4772990", "Костенко 6/3", group211, directory.Parents);
            directory.Students.Add(student9);
            directory.listChildren.Add(student9);
            Student student10 = new Student("Кристина", "Дробная", "Денисовна", Gender.Female, "KW228673", "Короткова 11Д", group211);
            directory.Students.Add(student10);
            Student student11 = new Student("Лариса", "Николина", "Романовна", Gender.Female, "HF475011", "Костен 34Б", group211, directory.Parents);
            directory.Students.Add(student11);
            directory.listChildren.Add(student11);
            #endregion
            Teachers teachers1 = new Teachers("Валерия", "Носкова", "Дмитривна", Gender.Female, "YU1228390", "Пролужный 45", department, Position.Lecturer);
            directory.Teachers.Add(teachers1);
            Teachers teachers2 = new Teachers("Николай", "Любимов", "Викторович", Gender.Male, "IR225576", "Подмостовой 12", department, Position.Professor);
            directory.Teachers.Add(teachers2);
            Teachers teachers3 = new Teachers("Сергей", "Курносов", "Леонидович", Gender.Male, "RE122367", "Утрений 24/3", department, Position.Assistant);
            directory.Teachers.Add(teachers3);

            Parents parents1 = new Parents("Иван", "Куртов", "Иванович", Gender.Male, "AD234586", "Кутузовский 2", directory.listChildren);
            Parents parents2 = new Parents("Катерина", "Епищенко", "Вениаминовна", Gender.Female, "HF234677", "Суворова 23", directory.listChildren);
            Parents parents3 = new Parents("Маша", "Лаврова", "Александровна", Gender.Female, "SW823441", "Судостроительный 12", directory.listChildren);

            foreach (Student students in directory.Students)
            {
                Console.WriteLine($"{students.Name} {students.Surname} {students.Patronymic}");
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            
            List<Student> sortedStudents = directory.GetSortedStudents("ФИО");
            foreach (var students in sortedStudents)
            {
                Console.WriteLine($"{students.Name} {students.Surname} {students.Patronymic}");
            }
        }


    }
}
