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

namespace Ex5_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] myArray = {5, 10, 15, 20, 25, 30, 35, 40, 45, 50};

          Console.WriteLine("=========== Dorset College Indefinite Sum ===========\n");

          Sum(5);
          Sum(5, 10, 15);
          Sum(5, 10, 15, 20, 25);
          Sum(myArray);
          Sum(5, 10, 15, 20, 25, 30, 35, 40, 45, 50);

          Console.WriteLine("\n=========== Dorset College Indefinite Sum ===========");

          Console.Write("\nPress \"Enter/Return\" to end... ");
          Console.ReadLine();
        }

        static void Sum(params int[] nums) {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            Console.WriteLine($"The sum of [{string.Join(", ",nums)}] is {sum}.");
        }
    }
}
