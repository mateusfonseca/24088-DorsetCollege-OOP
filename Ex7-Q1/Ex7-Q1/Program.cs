/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

DETAILS details = new("Suresh", "Hyderabad", 32);
Console.WriteLine(details.ToString());
Console.Write("\nPress Any Key to Exit... ");
Console.ReadKey();

abstract class CUSTOMER
{
    private String Name { get; set; }
    private String Location { get; set; }
    private int Age { get; set; }

    public CUSTOMER(String name, String location, int age)
    {
        Name = name;
        Location = location;
        Age = age;
        Console.WriteLine("Base Class Constructor");
    }

    public override string ToString()
    {
        return $"Name: {Name}\nLocation: {Location}\nAge: {Age}";
    }
}

class DETAILS : CUSTOMER
{
    public DETAILS(String name, String location, int age) : base(name, location, age)
    {
        Console.WriteLine("Child Class Constructor");
    }
}