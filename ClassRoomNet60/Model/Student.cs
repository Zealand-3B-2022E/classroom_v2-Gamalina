using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.Model
{
    public class Student
    {
        public string _name;
        public int _birthMonth;
        public int _birthday;

        public Student(string name, int birthMonth, int birthday)
        {
            _name = name;
            _birthMonth = birthMonth;
            _birthday = birthday;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int BirthMonth
        {
            get => _birthMonth;
            set => _birthMonth = value;
        }

        public int Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }


    }
}
