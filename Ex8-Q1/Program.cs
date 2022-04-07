/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

var conv = new Convertable();

var integer = conv.Convert(5);
var boolean = conv.Convert(true);
var number = conv.Convert(10.5);

Console.WriteLine($"{integer} has been converted to {integer.GetType()}");
Console.WriteLine($"{boolean} has been converted to {boolean.GetType()}");
Console.WriteLine($"{number} has been converted to {number.GetType()}");

class Convertable
{
    public string Convert(int integer)
    {
        return $"{integer}";
    }

    public string Convert(bool boolean)
    {
        return $"{boolean}";
    }

    public string Convert(double number)
    {
        return $"{number}";
    }
}