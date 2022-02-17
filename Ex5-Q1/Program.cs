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

namespace Ex5_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
          int num = 1;
          bool loop = false;

          Console.WriteLine("=========== Dorset College Multiplication Table ===========");

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
                loop = true;
            }
          } while (loop);

          MultiplicationTable(num);

          Console.WriteLine("\n=========== Dorset College Multiplication Table ===========");

          Console.Write("\nPress \"Enter/Return\" to end... ");
          Console.ReadLine();
        }

        static void MultiplicationTable(int num) {
            Console.WriteLine($"\nThe multiplication table for {num} is:\n");
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{num} \u00d7 {i} = {(long)num*i}");
            }
        }
    }
}
