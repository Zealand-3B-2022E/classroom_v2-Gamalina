// See https://aka.ms/new-console-template for more information

using ClassRoomNet60.Model;
using System.Security.Cryptography.X509Certificates;

var classRoom = new Classroom();


DateTime SemesterStartDateTime = new DateTime(2022, 9, 01);
classRoom.SemesterStart = SemesterStartDateTime;
Classroom classroom1 = new Classroom(classRoom.Name, classRoom.ClassName, classRoom.SemesterStart);

Classroom classroomList = new Classroom();

classroomList.AddPerson(classroom1);
classroomList.PrintAll();


Student studentList = new Student();
Student person1 = new Student("Daniel", 12, 04);
Student person2 = new Student("Benjamin", 2, 11);
Student person3 = new Student("Hannibal", 3, 27);
Student person4 = new Student("Cem", 5, 13);
Student person5 = new Student("Kasper", 6, 01);
Student person6 = new Student("Frida", 8, 09);
Student person7 = new Student("Chris", 9, 18);
Student person8 = new Student("Paul", 11, 30);
Student person9 = new Student("Erik", 4, 24);

studentList.AddPerson(person1);
studentList.AddPerson(person2);
studentList.AddPerson(person3);
studentList.AddPerson(person4);
studentList.AddPerson(person5);
studentList.AddPerson(person6);
studentList.AddPerson(person7);
studentList.AddPerson(person8);
studentList.AddPerson(person9);


studentList.PrintAll();

Console.WriteLine();
studentList.BirthMonthBySeasons();
