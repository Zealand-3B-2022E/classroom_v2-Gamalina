using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.Model
{
    public class Classroom
    {
        public string _className;
        public string _name;
        public List<Classroom> _classList;
        public DateTime _SemesterStart;
        public List<Student> _studentsList;




        public Classroom()
        {
            _classList = new List<Classroom>();
            _studentsList = new List<Student>();

        }

        public void AddPerson(Classroom person)
        {
            _classList.Add(person);
        }

        public void PrintAll()
        {
            var classRoom = new Classroom();
            classRoom.ClassName = "3B";
            classRoom.Name = "D2.09";

            DateTime SemesterStartDateTime = new DateTime(2022, 9, 01);
            classRoom.SemesterStart = SemesterStartDateTime;
            Console.WriteLine("Class Name: " + classRoom.ClassName);
            Console.WriteLine("Room: " + classRoom.Name);
            Console.WriteLine("Semester Start: " + classRoom.SemesterStart);
            Console.WriteLine(" ");
        }



        public Classroom(string name, string className, DateTime semesterStart)
        {
            _name = name;
            _className = className;
            _classList = new List<Classroom>();
            _SemesterStart = semesterStart;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }


        public string ClassName
        {
            get => _className;
            set => _className = value ?? throw new ArgumentNullException(nameof(value));
        }

        public List<Classroom> ClassList
        {
            get => _classList;
            set => _classList = value ?? throw new ArgumentNullException(nameof(value));
        }
        

        public DateTime SemesterStart
        {
            get => _SemesterStart;
            set => _SemesterStart = value;
        }



    }
}
