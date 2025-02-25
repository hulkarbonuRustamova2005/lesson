using StudentMenegment.Contexts;
using StudentMenegment.Entities;
using System.Windows.Markup;
using var dbContext = new StudentsContext();

var student = new Student()
{
    Id = 2,
    Firstname = "Abbos",
    Lastname = "Ikromov",
    Email = "abbosjonIkromov@gmail.com",
    IsActive = true
};
//dbContext.Students.Add(student);        
//dbContext.SaveChanges();        
//var existingStudent= dbContext.Students.Find(3 );
//var filteredStudents = dbContext.Students.Where(s => s.Firstname == "Abbos ");


//var students = dbContext.Students.ToList();

//foreach (var dbStudent in students)
//{
//    Console.WriteLine($"FullName: {dbStudent.Firstname} {dbStudent.Lastname}");
//}
//dbContext.Students.Update(student);
//dbContext.SaveChanges();
//foreach (var dbStudent in students)
//{
//    Console.WriteLine($"FullName: {dbStudent.Firstname} {dbStudent.Lastname}");
//}
var update =dbContext.Students.FirstOrDefault(x=>x.Id==1);
update.Firstname = "jasur";
update.Lastname = "ikromov";    
dbContext.SaveChanges();


Console.ReadLine();




