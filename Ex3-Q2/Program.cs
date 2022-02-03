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

namespace Ex3_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
          int sum = 0, n = 50, i=1;

          Console.WriteLine("======== Dorset College N-Ary Summation ========\n");

          for (int j=i; j<=n; j++) {
            sum += j;
            Console.WriteLine("{0,12} {1,6} {2,6} {3,6} {4,6}", sum-j, "+", j, "=", sum);
          }

          Console.WriteLine("\n================================================");
          Console.WriteLine("\n{0,19} {1,6} {2,8}", $"\u2211({i}\u2192 {n})", "=", sum);

          Console.WriteLine("\n======== Dorset College N-Ary Summation ========");

          Console.Write("\nPress \"Enter/Return\" to end... ");
          Console.ReadLine();
        }
    }
}
