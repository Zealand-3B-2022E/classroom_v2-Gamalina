using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ClassRoomNet60.Model
{
    public class Student
    {
        public string _name;
        public int _birthMonth;
        public int _birthday;
        public List<Student> _Students;

        public Student()
        {
            _Students = new List<Student>();
        }

        public Student(string name, int birthMonth, int birthday)
        {
            _name = name;
            _birthMonth = birthMonth;
            _birthday = birthday;
        }

        public void AddPerson(Student person)
        {
            _Students.Add(person);
        }
        public void PrintAll()
        {
            Console.WriteLine("List over Classrooms students");


            foreach (Student students in _Students)
            {
                Console.WriteLine("Student Name: " + students.Name);
                Console.WriteLine("Student Birthday: " + students.Birthday);
                Console.WriteLine("Student Birth Month: " + students.BirthMonth);
                Console.WriteLine("The student was born in: " + students.Seasons());
                Console.WriteLine(" ");
                
            }
        }

        public string Seasons()
        {
            if (BirthMonth >= 3 && BirthMonth <= 5)
            {
                return "Spring";
            }
            if (BirthMonth >= 6 && BirthMonth <= 8)
            {
                return "Summer";
            }
            if (BirthMonth >= 9 && BirthMonth <= 11)
            {
                return "Autumn";
            }
            else
            {
                return "Winter";
            }
        }

        public void BirthMonthBySeasons()
        {
            var seasons =
                from Student in _Students
                group Student by Student.Seasons()
                into birthMonthSeasons
                select new
                {
                    Seasons = birthMonthSeasons.Key,
                    Count = birthMonthSeasons.Count(),
                };

            foreach (var season in seasons)
            {
                Console.WriteLine(season.Seasons);
                Console.WriteLine(season.Count);
            }
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int BirthMonth
        {
            get { return _birthMonth; }

            private set
            {
                if (value >= 1 && value <= 12)
                {
                    _birthMonth = value;
                }
            }
        }

        public int Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }


    }
}
