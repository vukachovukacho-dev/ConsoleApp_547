using ConsoleApp_547.Models;

Student student = new Student();

student.Email = "invalid-email"; 
student.Email = "john@gmail.com"; 
Console.WriteLine($"Email: {student.Email}");


Student student2 = new Student("Anna", "anna@gmail.com")
{
    Birthdate = new DateOnly(2030, 1, 1)
};

Student student3 = new Student("David", "david@gmail.com")
{
    Birthdate = new DateOnly(2002, 5, 15) 
};
Console.WriteLine($"David's Birthdate: {student3.Birthdate}");

