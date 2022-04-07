/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

var blueTriangle = new ShapeAndColor(3, "blue");
var square = new ShapeAndColor(4);
var green = new ShapeAndColor("green");

blueTriangle.Display(blueTriangle.Sides, blueTriangle.Color);
square.Display(square.Sides);
green.Display(green.Color);

internal class ShapeAndColor
{
    public int Sides { get; }
    public string Color { get; }

    public ShapeAndColor(int sides, string color)
    {
        Sides = sides;
        Color = color;
    }

    public ShapeAndColor(int sides) : this(sides, "") {}

    public ShapeAndColor(string color) : this(0, color) {}

    public void Display(int sides)
    {
        Console.WriteLine($"This object has {sides} sides.");
    }
    
    public void Display(string color)
    {
        Console.WriteLine($"This object has {color} as its color code.");
    }
    
    public void Display(int sides, string color)
    {
        Display(sides);
        Display(color);
    }
}