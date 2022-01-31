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

namespace Ex1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
          int num1 = 0, num2 = 0;
          bool loop = false;

          Console.WriteLine("======== Dorset College Basic Calculator ========\n");

          do {
            try {
              Console.Write("Input first number: ");
              num1 = int.Parse(Console.ReadLine());
              loop = false;
            } catch (System.FormatException) {
              Console.WriteLine("\nInteger only! Please, try again.\n");
              loop = true;
            }
          } while (loop);

          do {
            try {
              Console.Write("Input second number: ");
              num2 = int.Parse(Console.ReadLine());
              loop = false;
            } catch (System.FormatException) {
              Console.WriteLine("\nInteger only! Please, try again.\n");
              loop = true;
            }
          } while (loop);

          Console.WriteLine("\n=================================================\n");
          Console.WriteLine("{0,16} {1,8} {2,12}", "Operation", " ", "Result");
          Console.WriteLine("{0,16} {1,8} {2,12}", $"{num1} + {num2}", "=", num1+num2);
          Console.WriteLine("{0,16} {1,8} {2,12}", $"{num1} \u2212 {num2}", "=", num1-num2);
          Console.WriteLine("{0,16} {1,8} {2,12}", $"{num1} \u00d7 {num2}", "=", num1*num2);
          try {
            Console.WriteLine("{0,16} {1,8} {2,12}", $"{num1} \u00f7 {num2}", "=", num1/num2);
            Console.WriteLine("{0,16} {1,8} {2,12}", $"{num1} % {num2}", "=", num1%num2);
          } catch (System.DivideByZeroException) {
            Console.WriteLine("{0,16} {1,8} {2,12}", $"{num1} \u00f7 {num2}", "=", "undefined");
            Console.WriteLine("{0,16} {1,8} {2,12}", $"{num1} % {num2}", "=", "undefined");
          }

          Console.WriteLine("\n======== Dorset College Basic Calculator ========");

          Console.Write("\nPress any key to end... ");
          Console.ReadLine();
        }
    }
}
