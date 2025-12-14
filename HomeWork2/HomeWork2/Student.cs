using System;

public class Student
{

  
    private string name;
    private int age;

   
    public string Name { get; set; }


    public int Age { get; set; }


    
    public Student(string name, int age)
    {
        Name= name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old");
    }
     static void Main(string[] args)
    {
        var student = new Student("bahar", 24);
        student.Introduce();
    }

}

