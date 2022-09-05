using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string NameofClass { get; set; }

        public List<Student> ListOfStudents { get; set; }

        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
            ListOfStudents = new List<Student>();
            SemesterStart = new DateTime();
        }

        public void WhichSeason()
        {
            var resultliste =
                this.ListOfStudents.GroupBy(x => x.Season())
                .Select(aarstidGroup => new {
                    aarstid = aarstidGroup.Key,
                    countAarstid = aarstidGroup.Count()
                });

            foreach (var item in resultliste)
            {
                Console.WriteLine($"Season: {item.aarstid} Count: {item.countAarstid} ");

            }
        }


    }
}
