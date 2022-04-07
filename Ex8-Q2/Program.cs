/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

var engine = new SpecificWhateverEngine(455, 3000, 6);

engine.Display();

internal abstract class Engine
{
    public int Power { get; }
    public int Rpm { get; }
    public int NumberOfCylinders { get; }

    protected Engine(int power, int rpm, int numberOfCylinders)
    {
        Power = power;
        Rpm = rpm;
        NumberOfCylinders = numberOfCylinders;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Base class {typeof(Engine)} with properties:");
        Console.WriteLine($" - {nameof(Power)} of type {Power.GetType()}.");
        Console.WriteLine($" - {nameof(Rpm)} of type {Rpm.GetType()}.");
        Console.WriteLine($" - {nameof(NumberOfCylinders)} of type {NumberOfCylinders.GetType()}.");
    }
}

class SpecificWhateverEngine : Engine
{
    public SpecificWhateverEngine(int power, int rpm, int numberOfCylinders) : base(power, rpm, numberOfCylinders) {}

    public override void Display()
    {
        Console.WriteLine($"This engine has {Power} horsepower, {Rpm} rpm and {NumberOfCylinders} cylinders.");
    }
}