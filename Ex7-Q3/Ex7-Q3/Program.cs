/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

CUSTOMER customer = new("Suresh", "Hyderabad", 32, "D8XR56");
Console.WriteLine(customer.ToString());

customer.Name = "John";
customer.Location = "Dublin";
customer.Age = 25;
customer.ZipCode = "D12834";

Console.WriteLine();

Console.WriteLine($"Name: {customer.Name}");
Console.WriteLine($"Location: {customer.Location}");
Console.WriteLine($"Age: {customer.Age}");
Console.WriteLine($"ZipCode: {customer.ZipCode}");

Console.Write("\nPress Any Key to Exit... ");
Console.ReadKey();

class CUSTOMER
{
    public String Name { get; set; }
    public String Location { get; set; }
    public int Age { get; set; }
    public String ZipCode { get; set; }

    public CUSTOMER(String name, String location, int age, String zipCode)
    {
        Name = name;
        Location = location;
        Age = age;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nLocation: {Location}\nAge: {Age}\nZip Code: {ZipCode}";
    }
}