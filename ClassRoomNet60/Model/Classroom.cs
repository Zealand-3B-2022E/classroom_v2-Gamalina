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
        public List<Classroom> _classList;
        public DateTime _SemesterStart;

        public Classroom(string className, List<Classroom> classList, DateTime semesterStart)
        {
            _className = className;
            _classList = classList;
            _SemesterStart = semesterStart;
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
