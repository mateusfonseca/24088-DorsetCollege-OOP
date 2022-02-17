/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

﻿using System;

namespace Ex5_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
          int num = 1;
          bool loop = false;

          Console.WriteLine("=========== Dorset College Square & Cube ===========");

          do {
            Console.Write("\nEnter an integer: ");
            try {
                num = int.Parse(Console.ReadLine());
                loop = false;
            } catch (System.FormatException) {
                Console.WriteLine("\nThe input has to be an integer! Please, try again.");
                loop = true;
            } catch (System.OverflowException) {
                Console.WriteLine($"\nThe input has to be between {Int32.MinValue} and {Int32.MaxValue}! Please, try again.");
                Console.WriteLine("==> Keep in mind that really large values may generate unexpected results.");
                loop = true;
            }
          } while (loop);

          Console.WriteLine($"\n{num}^2 = {Square(num)}");
          Console.WriteLine($"\n{num}^3 = {Cube(num)}");

          Console.WriteLine("\n=========== Dorset College Square & Cube ===========");

          Console.Write("\nPress \"Enter/Return\" to end... ");
          Console.ReadLine();
        }

        static long Square(int num) {
            return (long)num*num;
        }

        static long Cube(int num) {
            return (long)num*Square(num);
        }
    }
}
