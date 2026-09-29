namespace ConsoleApp_547.Models;

enum Grade
{
    A = 90,
    B = 80,
    C = 70,
    D = 60,
    E = 50,
    F = 0
}

internal class Student
{
    
    private string email;
    private DateOnly birthdate;
    private string name; 

    public int Id { get; set; }

    public string Name
    {
        get => name; 
        set
        {
            
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Name value cannot be null or whitespace!"); 
            }
        }
    }
    public string Email
    {
        get => email;
        set
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Contains("@") && value.Contains("."))
            {
                email = value;
            }
            else
            {
                Console.WriteLine("Email address must contain '@' and '.'!");
            }
        }
    }

    public DateOnly Birthdate
    {
        get => birthdate;
        init
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            if (value > today)
            {
                Console.WriteLine("Birthdate cannot be in the future!");
            }
            else if (value.Year < today.Year - 120)
            {
                Console.WriteLine("Invalid birthdate (too old)!");
            }
            else
            {
                birthdate = value;
            }
        }
    }

    public Grade Grade { get; set; }

    
    public Student()
    {
        
    }

    public Student(string name)
    {
        Name = name;
    }

    public Student(string name, string email)
    {
        Email = email;
    }
}
