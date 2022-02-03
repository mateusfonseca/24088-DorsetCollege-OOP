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

namespace Ex3_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
          double rate = 0, min = 5.65, max = 49.99;
          bool loop = false;

          Console.WriteLine("======== Dorset College Hourly Pay Rate Verifier 2.0 ========\n");

          do {
            try {
              Console.Write("Input hourly pay rate: ");
              rate = double.Parse(Console.ReadLine());
              if (rate < min || rate > max) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERROR! WRONG HOURLY PAY RATE INSERTED!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Your hourly pay rate has to be between {0:C} and {1:C}, inclusive! Please, try again.\n", min, max);
                loop = true;
              } else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nALL GOOD! YOUR HOURLY PAY RATE HAS BEEN SUCCESSFULLY VERIFIED!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Your hourly pay rate of {0:C} is between {1:C} and {2:C}! Nothing to worry about.", rate, min, max);
                loop = false;
              }
            } catch (System.FormatException) {
              Console.WriteLine("\nNumeric values only! Please, try again.\n");
              loop = true;
            }
          } while (loop);

          Console.WriteLine("\n======== Dorset College Hourly Pay Rate Verifier 2.0 ========");

          Console.Write("\nPress \"Enter/Return\" to end... ");
          Console.ReadLine();
        }
    }
}
