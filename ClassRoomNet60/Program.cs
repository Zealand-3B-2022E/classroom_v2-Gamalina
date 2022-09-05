// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, ClassRoom!");

//opgave 3
var classRoom = new ClassRoom();
classRoom.NameofClass = "Zealand-3";
classRoom.SemesterStart = new DateTime(2019, 1, 1);
classRoom.ListOfStudents.Add(new Student("Hans", 5, 7));
classRoom.ListOfStudents.Add(new Student("Grete", 3, 20));
classRoom.ListOfStudents.Add(new Student("Bo", 10, 1));
classRoom.ListOfStudents.Add(new Student("Grete1", 3, 1));
classRoom.ListOfStudents.Add(new Student("Grete2", 3, 2));
classRoom.ListOfStudents.Add(new Student("Grete3", 3, 3));
classRoom.ListOfStudents.Add(new Student("Grete4", 3, 4));
classRoom.ListOfStudents.Add(new Student("Bo1", 10, 1));
classRoom.ListOfStudents.Add(new Student("Bo2", 10, 2));
classRoom.ListOfStudents.Add(new Student("Bo3", 10, 3));
classRoom.ListOfStudents.Add(new Student("Bo4", 10, 4));
classRoom.ListOfStudents.Add(new Student("Bo5", 10, 5));

//task 4, Printout informations
Console.WriteLine($"ClassName : {classRoom.NameofClass}");
Console.WriteLine($"Semesterstart : {classRoom.SemesterStart}");
foreach (var students in classRoom.ListOfStudents)
{
    //Obs. I use override off the ToString() method in the Student class
    //to printout the information
    Console.WriteLine(students.ToString());
}

classRoom.WhichSeason();