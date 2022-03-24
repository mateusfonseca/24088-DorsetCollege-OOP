Z z = new("Suresh", "Hyderabad", 32, "D8X5T6", 233);
Console.WriteLine(z.ToString());
Console.Write("\nPress Any Key to Exit... ");
Console.ReadKey();

abstract class X
{
    private String Name { get; set; }
    private String Location { get; set; }
    private int Age { get; set; }
    private String ZipCode { get; set; }
    private int CustId { get; set; }

    public X(String name, String location, int age, String zipCode, int custId)
    {
        Name = name;
        Location = location;
        Age = age;
        ZipCode = zipCode;
        CustId = custId;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nLocation: {Location}\nAge: {Age}\nZip Code: {ZipCode}\nCustomer ID: {CustId}";
    }
}

abstract class Y : X
{
    public Y(String name, String location, int age, String zipCode, int custId) : base(name, location, age, zipCode, custId) {}
}

class Z : Y
{
    public Z(String name, String location, int age, String zipCode, int custId) : base(name, location, age, zipCode, custId) {}
}